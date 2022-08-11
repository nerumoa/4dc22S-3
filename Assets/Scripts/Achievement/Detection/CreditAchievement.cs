using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditAchievement : MonoBehaviour
{
    public void SetCredit()
    {
        PlayerPrefs.SetInt("CREDIT", 1);
    }
}
