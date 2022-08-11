using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidAchievement : MonoBehaviour
{
    int _void;

    void Awake()
    {
        _void = PlayerPrefs.GetInt("VOID", 0);
    }

    public void SetVoid()
    {
        _void = 1;
        PlayerPrefs.SetInt("VOID", _void);
    }
}
