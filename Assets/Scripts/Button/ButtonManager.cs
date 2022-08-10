using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    PlayerController pc;

    string[] a = new string[] { "W", "A", "S", "D", "UpArrow", "LeftArrow", "DownArrow", "RightArrow" };
    string[] b = new string[5];
    int tmp, num = 0;

    int numMax;
    float timer = 0f;
    float totalTimer = 0f;
    int timerMax;
    bool start = false;

    void Awake()
    {
        pc = GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("r")) {
            Init2();

            start = false;
            numMax = 5;
            for (int i = 0; i < numMax; i++) {
                tmp = UnityEngine.Random.Range(0, 7);
                b[i] = a[tmp];
            }
        }

        if (b[num] != null && !start) {
            if (pc.GetPressKey() == b[num]) {
                if (num < numMax - 1) {
                    num++;
                } else {
                    Init();
                }
            } else if (Array.IndexOf(a, pc.GetPressKey()) >= 0) {
                Init();
            }
        }




        if (Input.GetKeyDown("t")) {
            start = true;
            numMax = 1;
            tmp = UnityEngine.Random.Range(0, 7);
            b[0] = a[tmp];

            timer = 0f;
            timerMax = 50;

            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(4).gameObject.SetActive(false);
        }

        if (b[num] != null && start) {
            if (pc.GetPressKey() == b[num]) {
                if (num < numMax - 1) {
                    num++;
                } else {
                    Next();
                }
            } else if (Array.IndexOf(a, pc.GetPressKey()) >= 0) {
                Debug.Log("miss");
            }
        }

        if (start) {
            timer += Time.deltaTime;
            totalTimer += Time.deltaTime;

            if (timer >= timerMax) {
                Init2();
            }
        }
    }

    public string GetReqKey(int num)
    {
        if (0 <= num && num < 5) {
            if (b[num] != null) {
                return b[num];
            }
        }
        return "";
    }

    public bool EqualNum(int num)
    {   
        if (num == this.num && b[0] != null) {
            return true;
        } else {
            return false;
        }
    }

    public float GetTimer()
    {
        return timer;
    }

    public int GetTimerMax()
    {
        return timerMax;
    }

    private void Init()
    {
        Array.Fill(b, null);
        num = 0;
    }

    private void Init2()
    {
        start = false;
        timer = 0;
        totalTimer = 0;
        Init();

        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
        transform.GetChild(3).gameObject.SetActive(true);
        transform.GetChild(4).gameObject.SetActive(true);
    }

    private void Next()
    {
        num = 0;
        timer = 0f;

        if (totalTimer >= 25f) {
            timerMax = 2;
        } else if (totalTimer >= 20f) {
            numMax = 5;
            timerMax = 10;
            transform.GetChild(4).gameObject.SetActive(true);
        } else if (totalTimer >= 15f) {
            numMax = 4;
            timerMax = 20;
            transform.GetChild(3).gameObject.SetActive(true);
        } else if (totalTimer >= 10f) {
            numMax = 3;
            timerMax = 30;
            transform.GetChild(2).gameObject.SetActive(true);
        } else if (totalTimer >= 5f) {
            numMax = 2;
            timerMax = 40;
            transform.GetChild(1).gameObject.SetActive(true);
        }

        for (int i = 0; i < numMax; i++) {
            tmp = UnityEngine.Random.Range(0, 7);
            b[i] = a[tmp];
        }
    }
}
