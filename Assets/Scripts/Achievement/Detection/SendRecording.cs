using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendRecording : MonoBehaviour
{
    GameoverAchievement ga;
    ScoreAchievement sa;
    SuccessAchievement sua;
    DamageAchievement da;
    VoidAchievement va;
    GandhiAchievement gaa;

    private void Awake()
    {
        ga = GetComponent<GameoverAchievement>();
        sa = GetComponent<ScoreAchievement>();
        sua = GetComponent<SuccessAchievement>();
        da = GetComponent<DamageAchievement>();
        va = GetComponent<VoidAchievement>();
        gaa = GetComponent<GandhiAchievement>();
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

    public void SendDamageRecord()
    {
        da.AddDamageCount();
    }

    public void SendVoidRecord()
    {
        va.SetVoid();
    }

    public void SendGandhiRecord()
    {
        gaa.SetGandhi();
    }
}
