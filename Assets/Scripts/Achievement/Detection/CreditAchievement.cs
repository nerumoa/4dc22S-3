using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditAchievement : MonoBehaviour
{
    int credit;

    void Awake()
    {
        credit = PlayerPrefs.GetInt("CREDIT", 0);
    }

    public void SetCredit()
    {
        credit = 1;
        PlayerPrefs.SetInt("CREDIT", credit);
    }
}
