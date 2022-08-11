using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAchievement : MonoBehaviour
{
    static int startCount;

    [RuntimeInitializeOnLoadMethod()]
    static void Init()
    {
        startCount = PlayerPrefs.GetInt("START", 0);
        startCount++;
        PlayerPrefs.SetInt("START", startCount);
    }
}
