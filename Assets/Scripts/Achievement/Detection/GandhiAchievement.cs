using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GandhiAchievement : MonoBehaviour
{
    int gandhi;

    void Awake()
    {
        gandhi = PlayerPrefs.GetInt("GANDHI", 0);
    }

    public void SetGandhi()
    {
        gandhi = 1;
        PlayerPrefs.SetInt("GANDHI", gandhi);
    }
}
