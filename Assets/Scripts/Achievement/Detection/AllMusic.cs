using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllMusic : MonoBehaviour
{
    GameObject achievement;
    MusicAchievement ma;

    private void Awake()
    {
        achievement = GameObject.Find("Achievement");
        ma = achievement.GetComponent<MusicAchievement>();
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("MUSIC") == 1) {
            Destroy(gameObject);
        }
    }

    public void PressMusic0()
    {
        ma.SetMusic0();
    }

    public void PressMusic1()
    {
        ma.SetMusic1();
    }

    public void PressMusic2()
    {
        ma.SetMusic2();
    }

    public void PressMusic3()
    {
        ma.SetMusic3();
    }

    public void PressMusic4()
    {
        ma.SetMusic4();
    }

    public void PressMusic5()
    {
        ma.SetMusic5();
    }
}
