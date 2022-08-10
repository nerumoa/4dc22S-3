using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;

    public void AddScore(int i)
    {
        score += i;
    }

    public void ShowScore()
    {
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(score);
    }

    public void ResetScore()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.SetText("SCORE: {0}", score);
    }
}
