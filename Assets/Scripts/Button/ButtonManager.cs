using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] private GameObject TargetObject = default;
    [SerializeField] private GameObject scoreText = default;
    [SerializeField] private GameObject gameoverText = default;

    PlayerController pc;
    Score sc;
    GameObject[] B = new GameObject[6];

    string[] key_base = new string[] { "W", "A", "S", "D", "UpArrow", "LeftArrow", "DownArrow", "RightArrow" };
    string[] key = new string[5];
    int tmp, num = 0;
    int numMax;
    int hp = 3;
    float timer = 0f;
    float totalTimer = 0f;
    float timerMax;
    int score;
    bool start = false;
    bool cold = false;
    bool invi = false;
    public static bool gameover = false;

    void Awake()
    {
        pc = GetComponent<PlayerController>();
        sc = scoreText.GetComponent<Score>();
        sc.ResetScore();
        for (int i = 0; i < 6; i++) {
            B[i] = transform.GetChild(i).gameObject;
        }
    }

    private void Update()
    {
        if (TargetObject != null) {
            return;
        }

        if (!start) {
            Init();
        } else {
            if (!cold) {
                timer += Time.deltaTime;
            }
            totalTimer += Time.deltaTime;
            if (timer >= timerMax) {
                Gameover();
            }
        }

        if (hp <= 0) {
            Gameover();
        }

        if (key[num] != null && start && !cold) {
            if (pc.GetPressKey() == key[num]) {
                if (num < numMax - 1) {
                    num++;
                } else {
                    Next();
                }
            } else if (Array.IndexOf(key_base, pc.GetPressKey()) >= 0) {
                Damage();
            }
        }

        if (gameover && pc.GetAnyKey()) {
            SceneManager.LoadScene("GameClearScene");
        }
    }

    private void Init()
    {
        start = true;
        numMax = 2;
        timer = 0f;
        timerMax = 10f;
        score = 200;
        SetKey();

        B[0].gameObject.SetActive(true);
        B[1].gameObject.SetActive(true);
        B[5].gameObject.SetActive(true);
    }

    private void SetKey()
    {
        for (int i = 0; i < numMax; i++) {
            tmp = UnityEngine.Random.Range(0, 7);
            key[i] = key_base[tmp];
        }
    }

    private void Damage()
    {
        if (!invi) {
            hp--;
            StartCoroutine("Invincible");
        }

    }

    IEnumerator Invincible()
    {
        invi = true;
        yield return new WaitForSeconds(1.0f);
        invi = false;
    }

    private void Gameover()
    {
        cold = true;
        gameover = true;
        gameoverText.SetActive(true);
    }

    private void Next()
    {
        cold = true;
        sc.AddScore(score);
        StartCoroutine("NextKey");
    }

    IEnumerator NextKey()
    {
        yield return new WaitForSeconds(0.4f);

        cold = false;
        num = 0;
        timer = 0f;
        SetTimer();
        SetKey();
    }

    private void SetTimer()
    {
        if (totalTimer >= 240f) {
            timerMax = 2.5f;
            score = 1000;
        } else if (totalTimer >= 220f) {
            timerMax = 2.66f;
            score = 900;
        } else if (totalTimer >= 200f) {
            timerMax = 2.83f;
            score = 850;
        } else if (totalTimer >= 180f) {
            timerMax = 3.0f;
            score = 800;
        } else if (totalTimer >= 160f) {
            timerMax = 3.2f;
            score = 750;
        } else if (totalTimer >= 140f) {
            timerMax = 3.4f;
            score = 700;
        } else if (totalTimer >= 120f) {
            timerMax = 3.6f;
            score = 650;
        } else if (totalTimer >= 100f) {
            timerMax = 3.8f;
            score = 600;
        } else if (totalTimer >= 80f) {
            timerMax = 4.0f;
            score = 550;
        } else if (totalTimer >= 60f) {
            Fifth();
            timerMax = 5.0f;
            score = 500;
        } else if (totalTimer >= 50f) {
            timerMax = 6.0f;
        } else if (totalTimer >= 40f) {
            Fourth();
            timerMax = 7.0f;
            score = 400;
        } else if (totalTimer >= 30f) {
            timerMax = 8.0f;
        } else if (totalTimer >= 20f) {
            Third();
            timerMax = 9.0f;
            score = 300;
        }
    }

    private void Third()
    {
        numMax = 3;
        B[0].transform.position = new Vector2(-2f, -4.2f);
        B[1].transform.position = new Vector2(0f, -4.2f);
        B[2].SetActive(true);
    }

    private void Fourth()
    {
        numMax = 4;
        B[0].transform.position = new Vector2(-3f, -4.2f);
        B[1].transform.position = new Vector2(-1f, -4.2f);
        B[2].transform.position = new Vector2(1f, -4.2f);
        B[3].SetActive(true);
    }

    private void Fifth()
    {
        numMax = 5;
        B[0].transform.position = new Vector2(-4f, -4.2f);
        B[1].transform.position = new Vector2(-2f, -4.2f);
        B[2].transform.position = new Vector2(0f, -4.2f);
        B[3].transform.position = new Vector2(2f, -4.2f);
        B[4].SetActive(true);
    }

    public string GetReqKey(int num)
    {
        if (0 <= num && num < 5) {
            if (key[num] != null) {
                return key[num];
            }
        }
        return "";
    }

    public bool EqualNum(int num)
    {   
        if (num == this.num && key[0] != null) {
            return true;
        } else {
            return false;
        }
    }

    public int GetHP()
    {
        return hp;
    }

    public float GetTimer()
    {
        return timer;
    }

    public float GetTimerMax()
    {
        return timerMax;
    }
}
