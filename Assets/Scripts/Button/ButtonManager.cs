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
    [SerializeField] private GameObject achievement = default;
    [SerializeField] private AudioClip soundeffect_peti = default;
    [SerializeField] private AudioClip soundeffect_pan = default;
    [SerializeField] private AudioClip soundeffect_damage = default;

    public Animator animator_usa;
    public Animator animator_sen;

    PlayerController pc;
    Score sc;
    SendRecording sr;
    AudioSource audio;
    GameObject[] B = new GameObject[6];

    string[] key_base = new string[] { "W", "A", "S", "D", "UpArrow", "LeftArrow", "DownArrow", "RightArrow" };
    string[] key = new string[5];
    int tmp, num = 0;
    int numMax;
    int hp = 3;
    float timer = 0f;
    float totalTimer = 0f;
    float timerMax;
    int addScore, score;
    bool start = false;
    bool cold = false;
    bool invi = false;
    bool gandhi = false;
    public static bool gameover = false;


    void Awake()
    {
        pc = GetComponent<PlayerController>();
        sr = achievement.GetComponent<SendRecording>();
        sc = scoreText.GetComponent<Score>();
        audio = GetComponent<AudioSource>();
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
                    audio.PlayOneShot(soundeffect_peti);
                    Animation();
                    num++;
                } else {
                    audio.PlayOneShot(soundeffect_pan);
                    Animation();
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
        gameover = false;
        numMax = 2;
        timer = 0f;
        timerMax = 10f;
        addScore = 200;
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
            audio.PlayOneShot(soundeffect_damage);
            sr.SendDamageRecord();
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
        if (!gameover) {
            cold = true;
            gameover = true;
            sr.SendGameoverRecord();
            if (!gandhi) {
                sr.SendGandhiRecord();
            }
            gameoverText.SetActive(true);
        }
    }

    private void Next()
    {
        cold = true;
        gandhi = true;
        sc.AddScore(addScore);
        score = sc.GetScore();
        sr.SendSuccessRecord();
        sr.SendScoreRecord(score, addScore);
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
            addScore = 1000;
        } else if (totalTimer >= 220f) {
            timerMax = 2.66f;
            addScore = 900;
        } else if (totalTimer >= 200f) {
            timerMax = 2.83f;
            addScore = 850;
        } else if (totalTimer >= 180f) {
            timerMax = 3.0f;
            addScore = 800;
        } else if (totalTimer >= 160f) {
            timerMax = 3.2f;
            addScore = 750;
        } else if (totalTimer >= 140f) {
            timerMax = 3.4f;
            addScore = 700;
        } else if (totalTimer >= 120f) {
            timerMax = 3.6f;
            addScore = 650;
        } else if (totalTimer >= 100f) {
            timerMax = 3.8f;
            addScore = 600;
        } else if (totalTimer >= 80f) {
            timerMax = 4.0f;
            addScore = 550;
        } else if (totalTimer >= 60f) {
            Fifth();
            timerMax = 5.0f;
            addScore = 500;
        } else if (totalTimer >= 50f) {
            timerMax = 6.0f;
        } else if (totalTimer >= 40f) {
            Fourth();
            timerMax = 7.0f;
            addScore = 400;
        } else if (totalTimer >= 30f) {
            timerMax = 8.0f;
        } else if (totalTimer >= 20f) {
            Third();
            timerMax = 9.0f;
            addScore = 300;
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

    public void Animation()
    {
        animator_usa.SetTrigger("Trigger");
        animator_sen.SetTrigger("Trigger");
    }
}
