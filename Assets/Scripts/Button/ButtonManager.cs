using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] private GameObject TargetObject = default;
    PlayerController pc;

    string[] key_base = new string[] { "W", "A", "S", "D", "UpArrow", "LeftArrow", "DownArrow", "RightArrow" };
    string[] key = new string[5];
    int tmp, num = 0;
    int numMax;
    float timer = 0f;
    float totalTimer = 0f;
    float timerMax;
    bool start = false;

    void Awake()
    {
        pc = GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (TargetObject != null) {
            return;
        }

        if (!start) {
            Init();
        } else {
            timer += Time.deltaTime;
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
        SetKey();

        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(5).gameObject.SetActive(true);
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
        num = 0;
        timer = 0f;
        if (totalTimer >= 340f) {
            timerMax = 1.5f;
        } else if (totalTimer >= 320f) {
            timerMax = 1.66f;
        } else if (totalTimer >= 300f) {
            timerMax = 1.83f;
        } else if (totalTimer >= 280f) {
            timerMax = 2.0f;
        } else if (totalTimer >= 260f) {
            timerMax = 2.2f;
        } else if (totalTimer >= 240f) {
            timerMax = 2.4f;
        } else if (totalTimer >= 220f) {
            timerMax = 2.6f;
        } else if (totalTimer >= 200f) {
            timerMax = 2.8f;
        } else if (totalTimer >= 180f) {
            timerMax = 3.0f;
        } else if (totalTimer >= 160f) {
            timerMax = 3.2f;
        } else if (totalTimer >= 140f) {
            timerMax = 3.4f;
        } else if (totalTimer >= 120f) {
            timerMax = 3.6f;
        } else if (totalTimer >= 100f) {
            timerMax = 3.8f;
        } else if (totalTimer >= 80f) {
            timerMax = 4.0f;
        } else if (totalTimer >= 60f) {
            numMax = 5;
            timerMax = 5.0f;
            transform.GetChild(4).gameObject.SetActive(true);
        } else if (totalTimer >= 50f) {
            timerMax = 6.0f;
        } else if (totalTimer >= 40f) {
            numMax = 4;
            timerMax = 7.0f;
            transform.GetChild(3).gameObject.SetActive(true);
        } else if (totalTimer >= 30f){
            timerMax = 8.0f;
        } else if (totalTimer >= 20f) {
            numMax = 3;
            timerMax = 9.0f;
            transform.GetChild(2).gameObject.SetActive(true);
        }

        SetKey();
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
