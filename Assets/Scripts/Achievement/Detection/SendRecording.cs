using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendRecording : MonoBehaviour
{
    GameoverAchievement ga;
    ScoreAchievement sa;
    SuccessAchievement sua;
    DamageAchievement da;
    MotiAchievement ma;
    CreditAchievement ca;
    VoidAchievement va;
    GandhiAchievement gaa;
    AllAchievement aa;

    private void Awake()
    {
        ga = GetComponent<GameoverAchievement>();
        sa = GetComponent<ScoreAchievement>();
        sua = GetComponent<SuccessAchievement>();
        da = GetComponent<DamageAchievement>();
        ma = GetComponent<MotiAchievement>();
        ca = GetComponent<CreditAchievement>();
        va = GetComponent<VoidAchievement>();
        gaa = GetComponent<GandhiAchievement>();
        aa = GetComponent<AllAchievement>();
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

    public void SendRareRecord()
    {
        ma.SetRare();
    }

    public void SendSRareRecord()
    {
        ma.SetSRare();
    }

    public void SendCreditRecord()
    {
        ca.SetCredit();
    }

    public void SendVoidRecord()
    {
        va.SetVoid();
    }

    public void SendGandhiRecord()
    {
        gaa.SetGandhi();
    }

    public void SendAllRecord()
    {
        aa.SetAll();
    }
}
