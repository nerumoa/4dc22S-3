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

    void Awake()
    {
        pc = GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("r")) {
            for (int i = 0; i < 5; i++) {
                tmp = UnityEngine.Random.Range(0, 7);
                b[i] = a[tmp];
            }
            Debug.Log(b[0] + ", " + b[1] + ", " + b[2] + ", " + b[3] + ", " + b[4]);
        }

        if (b[num] != null) {
            if (pc.GetPressKey() == b[num]) {
                Debug.Log("correct key press");
                if (num < 4) {
                    num++;
                } else {
                    Array.Fill(b, null);
                    num = 0;
                }
            } else if (Array.IndexOf(a, pc.GetPressKey()) >= 0) {
                Debug.Log("error key press");
                Array.Fill(b, null);
                num = 0;
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
}
