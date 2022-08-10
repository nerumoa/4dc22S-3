using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] private GameObject TargetObject = default;
    //[SerializeField] private GameObject scoreText = default;

    PlayerController pc;
    //Score sc;
    GameObject B0, B1, B2, B3, B4, B5;

    string[] key_base = new string[] { "W", "A", "S", "D", "UpArrow", "LeftArrow", "DownArrow", "RightArrow" };
    string[] key = new string[5];
    int tmp, num = 0;
    int numMax;
    float timer = 0f;
    float totalTimer = 0f;
    float timerMax;
    int score;
    bool start = false;
    bool cold = false;

    void Awake()
    {
        pc = GetComponent<PlayerController>();
        //sc = scoreText.GetComponent<Score>();
        B0 = transform.GetChild(0).gameObject;
        B1 = transform.GetChild(1).gameObject;
        B2 = transform.GetChild(2).gameObject;
        B3 = transform.GetChild(3).gameObject;
        B4 = transform.GetChild(4).gameObject;
        B5 = transform.GetChild(5).gameObject;
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

        if (key[num] != null && start) {
            if (pc.GetPressKey() == key[num]) {
                if (num < numMax - 1) {
                    num++;
                } else {
                    Next();
                }
            } else if (Array.IndexOf(key_base, pc.GetPressKey()) >= 0) {
                Debug.Log("miss");
            }
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

        B0.gameObject.SetActive(true);
        B1.gameObject.SetActive(true);
        B5.gameObject.SetActive(true);
    }

    private void SetKey()
    {
        for (int i = 0; i < numMax; i++) {
            tmp = UnityEngine.Random.Range(0, 7);
            key[i] = key_base[tmp];
        }
    }

    private void Gameover()
    {
        SceneManager.LoadScene("GameClearScene");
    }

    private void Next()
    {
        cold = true;
        //sc.AddScore(score);
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
        B0.transform.position = new Vector2(-2f, -4.2f);
        B1.transform.position = new Vector2(0f, -4.2f);
        B2.SetActive(true);
    }

    private void Fourth()
    {
        numMax = 4;
        B0.transform.position = new Vector2(-3f, -4.2f);
        B1.transform.position = new Vector2(-1f, -4.2f);
        B2.transform.position = new Vector2(1f, -4.2f);
        B3.SetActive(true);
    }

    private void Fifth()
    {
        numMax = 5;
        B0.transform.position = new Vector2(-4f, -4.2f);
        B1.transform.position = new Vector2(-2f, -4.2f);
        B2.transform.position = new Vector2(0f, -4.2f);
        B3.transform.position = new Vector2(2f, -4.2f);
        B4.SetActive(true);
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

    public float GetTimer()
    {
        return timer;
    }

    public float GetTimerMax()
    {
        return timerMax;
    }
}
