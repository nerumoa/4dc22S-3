using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAchievement : MonoBehaviour
{
    int startCount;

    void Awake()
    {
        startCount = PlayerPrefs.GetInt("START", 0);
        startCount++;
        PlayerPrefs.SetInt("START", startCount);
    }

    private void OnDestroy()
    {
        PlayerPrefs.Save();
    }

    /* Debug
    private void Update()
    {
        Debug.Log("Start:" + startCount);
    }
    */
}
