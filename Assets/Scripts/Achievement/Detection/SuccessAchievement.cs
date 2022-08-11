using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessAchievement : MonoBehaviour
{
    int successCount;

    void Awake()
    {
        successCount = PlayerPrefs.GetInt("SUCCESS", 0);
    }

    public void AddSuccessCount()
    {
        successCount++;
        PlayerPrefs.SetInt("SUCCESS", successCount);
    }
}
