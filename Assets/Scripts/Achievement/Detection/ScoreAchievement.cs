using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAchievement : MonoBehaviour
{
    int maxScore, allScore;

    void Awake()
    {
        maxScore = PlayerPrefs.GetInt("MAXSCORE", 0);
        allScore = PlayerPrefs.GetInt("ALLSCORE", 0);
    }

    public void SetMaxScore(int score)
    {
        if (maxScore < score) {
            maxScore = score;
            PlayerPrefs.SetInt("MAXSCORE", maxScore);
        }
    }

    public void AddAllScore(int addScore)
    {
        allScore += addScore;
        PlayerPrefs.SetInt("ALLSCORE", allScore);
    }
}
