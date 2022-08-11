using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendRecording : MonoBehaviour
{
    GameoverAchievement ga;
    ScoreAchievement sa;
    SuccessAchievement sua;

    private void Awake()
    {
        ga = GetComponent<GameoverAchievement>();
        sa = GetComponent<ScoreAchievement>();
        sua = GetComponent<SuccessAchievement>();
    }

    public void SendGameoverRecord()
    {
        ga.AddGameoverCount();
    }

    public void SendScoreRecord(int score, int addScore)
    {
        sa.SetMaxScore(score);
        sa.AddAllScore(addScore);
    }

    public void SendSuccessRecord()
    {
        sua.AddSuccessCount();
    }

}
