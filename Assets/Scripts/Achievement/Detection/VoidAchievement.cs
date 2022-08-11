using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidAchievement : MonoBehaviour
{
    public void SetVoid()
    {
        PlayerPrefs.SetInt("VOID", 1);
    }
}
