using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAchievement : MonoBehaviour
{
    int damageCount;

    void Awake()
    {
        damageCount = PlayerPrefs.GetInt("DAMAGE", 0);
    }

    public void AddDamageCount()
    {
        damageCount++;
        PlayerPrefs.SetInt("DAMAGE", damageCount);
    }
}
