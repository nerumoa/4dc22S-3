using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendRecording : MonoBehaviour
{
    GameoverAchievement ga;
    ScoreAchievement sa;

    private void Awake()
    {
        ga = GetComponent<GameoverAchievement>();
        sa = GetComponent<ScoreAchievement>();
    }

    public void SendScoreRecord(int score, int addScore)
    {
        sa.SetMaxScore(score);
        sa.AddAllScore(addScore);
    }

    public void SendGameoverRecord()
    {
        ga.AddGameoverCount();
    }
}
