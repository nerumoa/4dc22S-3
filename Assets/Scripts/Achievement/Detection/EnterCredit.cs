using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCredit : MonoBehaviour
{
    GameObject achievement;
    SendRecording sr;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("CREDIT") == 0) {
            achievement = GameObject.Find("Achievement");
            sr = achievement.GetComponent<SendRecording>();
            sr.SendCreditRecord();
        } else {
            Destroy(gameObject);
        }
    }
}
