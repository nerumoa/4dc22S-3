using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleTimer : MonoBehaviour
{
    [SerializeField] GameObject achievement = default;

    SendRecording sr;
    float timer = 0f;

    private void Awake()
    {
        sr = achievement.GetComponent<SendRecording>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 300f) {
            sr.SendVoidRecord();
        }
    }
}
