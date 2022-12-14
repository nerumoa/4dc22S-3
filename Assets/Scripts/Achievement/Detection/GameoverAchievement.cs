using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverAchievement : MonoBehaviour
{
    int gameoverCount;

    void Awake()
    {
        gameoverCount = PlayerPrefs.GetInt("GAMEOVER", 0);
    }

    public void AddGameoverCount()
    {
        gameoverCount++;
        PlayerPrefs.SetInt("GAMEOVER", gameoverCount);
    }
}
