using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GandhiAchievement : MonoBehaviour
{
    public void SetGandhi()
    {
        PlayerPrefs.SetInt("GANDHI", 1);
    }
}
