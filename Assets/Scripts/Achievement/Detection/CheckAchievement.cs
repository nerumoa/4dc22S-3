using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAchievement : MonoBehaviour
{
    int startCount, gameoverCount, maxScore, allScore, successCount;
    string achi1, achi2, achi3, achi4, achi5, achi6, achi7, achi8, achi9, achi10;
    string achi11, achi12, achi13, achi14, achi15, achi16, achi17, achi18, achi19;

    void Awake()
    {
        achi1 = PlayerPrefs.GetString("ACHI1", "FALSE");
        achi2 = PlayerPrefs.GetString("ACHI2", "FALSE");
        achi3 = PlayerPrefs.GetString("ACHI3", "FALSE");

        achi4 = PlayerPrefs.GetString("ACHI4", "FALSE");
        achi5 = PlayerPrefs.GetString("ACHI5", "FALSE");
        achi6 = PlayerPrefs.GetString("ACHI6", "FALSE");

        achi7 = PlayerPrefs.GetString("ACHI7", "FALSE");
        achi8 = PlayerPrefs.GetString("ACHI8", "FALSE");
        achi9 = PlayerPrefs.GetString("ACHI9", "FALSE");

        achi10 = PlayerPrefs.GetString("ACHI10", "FALSE");
        achi11 = PlayerPrefs.GetString("ACHI11", "FALSE");
        achi12 = PlayerPrefs.GetString("ACHI12", "FALSE");

        achi13 = PlayerPrefs.GetString("ACHI13", "FALSE");
        achi14 = PlayerPrefs.GetString("ACHI14", "FALSE");
        achi15 = PlayerPrefs.GetString("ACHI15", "FALSE");
    }

    private void OnDestroy()
    {
        PlayerPrefs.Save();
    }

    void Update()
    {
        startCount = PlayerPrefs.GetInt("START", 0);
        gameoverCount = PlayerPrefs.GetInt("GAMEOVER", 0);
        maxScore = PlayerPrefs.GetInt("MAXSCORE", 0);
        allScore = PlayerPrefs.GetInt("ALLSCORE", 0);
        successCount = PlayerPrefs.GetInt("SUCCESS", 0);

        if (startCount >= 2 && achi1 == "FALSE") {
            PlayerPrefs.SetString("ACHI1", "TRUE");
            achi1 = PlayerPrefs.GetString("ACHI1");
        } else if (startCount >= 3 && achi2 == "FALSE") {
            PlayerPrefs.SetString("ACHI2", "TRUE");
            achi2 = PlayerPrefs.GetString("ACHI2");
        } else if (startCount >= 4 && achi3 == "FALSE") {
            PlayerPrefs.SetString("ACHI3", "TRUE");
            achi3 = PlayerPrefs.GetString("ACHI3");

        } else if (gameoverCount >= 1 && achi4 == "FALSE") {
            PlayerPrefs.SetString("ACHI4", "TRUE");
            achi4 = PlayerPrefs.GetString("ACHI4");
        } else if (gameoverCount >= 5 && achi5 == "FALSE") {
            PlayerPrefs.SetString("ACHI5", "TRUE");
            achi5 = PlayerPrefs.GetString("ACHI5");
        } else if (gameoverCount >= 10 && achi6 == "FALSE") {
            PlayerPrefs.SetString("ACHI6", "TRUE");
            achi6 = PlayerPrefs.GetString("ACHI6");

        } else if (maxScore >= 10000 && achi7 == "FALSE") {
            PlayerPrefs.SetString("ACHI7", "TRUE");
            achi7 = PlayerPrefs.GetString("ACHI7");
        } else if (maxScore >= 50000 && achi8 == "FALSE") {
            PlayerPrefs.SetString("ACHI8", "TRUE");
            achi8 = PlayerPrefs.GetString("ACHI8");
        } else if (maxScore >= 100000 && achi9 == "FALSE") {
            PlayerPrefs.SetString("ACHI9", "TRUE");
            achi9 = PlayerPrefs.GetString("ACHI9");

        } else if (allScore >= 200000 && achi10 == "FALSE") {
            PlayerPrefs.SetString("ACHI10", "TRUE");
            achi10 = PlayerPrefs.GetString("ACHI10");
        } else if (allScore >= 300000 && achi11 == "FALSE") {
            PlayerPrefs.SetString("ACHI11", "TRUE");
            achi11 = PlayerPrefs.GetString("ACHI11");
        } else if (maxScore >= 500000 && achi12 == "FALSE") {
            PlayerPrefs.SetString("ACHI12", "TRUE");
            achi12 = PlayerPrefs.GetString("ACHI12");

        } else if (successCount >= 10 && achi13 == "FALSE") {
            PlayerPrefs.SetString("ACHI13", "TRUE");
            achi13 = PlayerPrefs.GetString("ACHI13");
        } else if (successCount >= 100 && achi14 == "FALSE") {
            PlayerPrefs.SetString("ACHI14", "TRUE");
            achi14 = PlayerPrefs.GetString("ACHI14");
        } else if (successCount >= 1000 && achi15 == "FALSE") {
            PlayerPrefs.SetString("ACHI15", "TRUE");
            achi15 = PlayerPrefs.GetString("ACHI15");
        }
    }
}
