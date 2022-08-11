using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicAchievement : MonoBehaviour
{
    int[] music = new int[6];
    int allMusic;

    void Awake()
    {
        music[0] = PlayerPrefs.GetInt("MUSIC0", 0);
        music[1] = PlayerPrefs.GetInt("MUSIC1", 0);
        music[2] = PlayerPrefs.GetInt("MUSIC2", 0);
        music[3] = PlayerPrefs.GetInt("MUSIC3", 0);
        music[4] = PlayerPrefs.GetInt("MUSIC4", 0);
        music[5] = PlayerPrefs.GetInt("MUSIC5", 0);
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("MUSIC") == 0) {
            allMusic = 0;
            for (int i = 0; i < 6; i++) {
                allMusic += music[i];
            }

            if (allMusic == 6) {
                PlayerPrefs.SetInt("MUSIC", 1);
            }
        }
    }

    public void SetMusic0()
    {
        music[0] = 1;
        PlayerPrefs.SetInt("MUSIC0", music[0]);
    }

    public void SetMusic1()
    {
        music[1] = 1;
        PlayerPrefs.SetInt("MUSIC1", music[1]);
    }

    public void SetMusic2()
    {
        music[2] = 1;
        PlayerPrefs.SetInt("MUSIC2", music[2]);
    }

    public void SetMusic3()
    {
        music[3] = 1;
        PlayerPrefs.SetInt("MUSIC3", music[3]);
    }

    public void SetMusic4()
    {
        music[4] = 1;
        PlayerPrefs.SetInt("MUSIC4", music[4]);
    }

    public void SetMusic5()
    {
        music[5] = 1;
        PlayerPrefs.SetInt("MUSIC5", music[5]);
    }

}
