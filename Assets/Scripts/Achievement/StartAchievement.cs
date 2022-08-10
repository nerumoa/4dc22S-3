using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAchievement : MonoBehaviour
{
    int startCount;

    void Awake()
    {
        startCount = PlayerPrefs.GetInt("START", 0);
    }

    private void Start()
    {
        startCount++;
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("START", startCount);
        PlayerPrefs.Save();
    }

    private void Update()
    {
        Debug.Log("Start:" + startCount);
    }

    public int GetStartCount()
    {
        return startCount;
    }
}
