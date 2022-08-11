using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllAchievement : MonoBehaviour
{
    public void SetAll()
    {
        PlayerPrefs.SetInt("ALL", 1);
    }
}
