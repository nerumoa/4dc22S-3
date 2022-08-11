using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotiAchievement : MonoBehaviour
{
    int rare, sRare;

    void Awake()
    {
        rare = PlayerPrefs.GetInt("RARE", 0);
        sRare = PlayerPrefs.GetInt("SRARE", 0);
    }

    public void SetRare()
    {
        rare = 1;
        PlayerPrefs.SetInt("RARE", rare);
    }

    public void SetSRare()
    {
        sRare = 1;
        PlayerPrefs.SetInt("SRARE", sRare);
    }
}
