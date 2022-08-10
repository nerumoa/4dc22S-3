using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoreText;

    public void AddScore()
    {
        score++;
    }

    void Update()
    {
        scoreText.SetText("SCORE: {0}", score);
    }
}
