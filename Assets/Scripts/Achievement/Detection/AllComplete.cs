using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllComplete : MonoBehaviour
{
    [SerializeField] GameObject buttonRight;

    GameObject achievement;
    SendRecording sr;
    string[] achi = new string[26];

    void Awake()
    {
        achievement = GameObject.Find("Achievement");
        sr = achievement.GetComponent<SendRecording>();

        for (int i = 1; i <= 24; i++) {
            achi[i] = PlayerPrefs.GetString("ACHI" + i, "FALSE");
        }

        for (int i = 1; i <= 24; i++) {
            if (achi[i] != "FINISH") {
                Destroy(gameObject);
            }
        }
    }

    private void Start()
    {
        buttonRight.SetActive(true);
        sr.SendAllRecord();
        Destroy(gameObject);
    }
}
