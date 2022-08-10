using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoreText;

    public void AddScore(int i)
    {
        score += i;
    }

    public void ShowScore()
    {
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(score);
    }

    void Update()
    {
        scoreText.SetText("SCORE: {0}", score);
    }
}
