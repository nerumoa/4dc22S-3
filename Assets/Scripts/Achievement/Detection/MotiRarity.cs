using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotiRarity : MonoBehaviour
{
    GameObject achievement;
    SendRecording sr;
    bool find = false;

    private void Awake()
    {
        achievement = GameObject.Find("Achievement");
        sr = achievement.GetComponent<SendRecording>();
    }

    void Update()
    {
        if (!find) {
            find = true;
            if (GameObject.Find("kagamimoti_R")) {
                sr.SendRareRecord();
            } else if (GameObject.Find("kagamimoti_SR")) {
                sr.SendSRareRecord();
            }
        }
    }
}
