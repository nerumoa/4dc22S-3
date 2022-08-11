using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAchievement : MonoBehaviour
{
    int startCount, gameoverCount, maxScore, allScore, successCount, damageCount;
    int rare, sRare, credit, _void, gandhi;
    string[] achi = new string[25];

    void Awake()
    {
        for (int i = 1; i <= 24; i++) {
            achi[i] = PlayerPrefs.GetString("ACHI" + i, "FALSE");
        }
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
        damageCount = PlayerPrefs.GetInt("DAMAGE", 0);
        rare = PlayerPrefs.GetInt("RARE", 0);
        sRare = PlayerPrefs.GetInt("SRARE", 0);
        credit = PlayerPrefs.GetInt("CREDIT", 0);
        _void = PlayerPrefs.GetInt("VOID", 0);
        gandhi = PlayerPrefs.GetInt("GANDHI", 0);

        if (successCount >= 10 && achi[1] == "FALSE") {
            PlayerPrefs.SetString("ACHI1", "TRUE");
            achi[1] = PlayerPrefs.GetString("ACHI1");
        } else if (successCount >= 100 && achi[2] == "FALSE") {
            PlayerPrefs.SetString("ACHI2", "TRUE");
            achi[2] = PlayerPrefs.GetString("ACHI2");
        } else if (successCount >= 1000 && achi[3] == "FALSE") {
            PlayerPrefs.SetString("ACHI3", "TRUE");
            achi[3] = PlayerPrefs.GetString("ACHI3");

        } else if (damageCount >= 5 && achi[4] == "FALSE") {
            PlayerPrefs.SetString("ACHI4", "TRUE");
            achi[4] = PlayerPrefs.GetString("ACHI4");
        } else if (damageCount >= 25 && achi[5] == "FALSE") {
            PlayerPrefs.SetString("ACHI5", "TRUE");
            achi[5] = PlayerPrefs.GetString("ACHI5");
        } else if (damageCount >= 50 && achi[6] == "FALSE") {
            PlayerPrefs.SetString("ACHI6", "TRUE");
            achi[6] = PlayerPrefs.GetString("ACHI6");

        } else if (gameoverCount >= 1 && achi[7] == "FALSE") {
            PlayerPrefs.SetString("ACHI7", "TRUE");
            achi[7] = PlayerPrefs.GetString("ACHI7");
        } else if (gameoverCount >= 5 && achi[8] == "FALSE") {
            PlayerPrefs.SetString("ACHI8", "TRUE");
            achi[8] = PlayerPrefs.GetString("ACHI8");
        } else if (gameoverCount >= 10 && achi[9] == "FALSE") {
            PlayerPrefs.SetString("ACHI9", "TRUE");
            achi[9] = PlayerPrefs.GetString("ACHI9");

        } else if (maxScore >= 10000 && achi[10] == "FALSE") {
            PlayerPrefs.SetString("ACHI10", "TRUE");
            achi[10] = PlayerPrefs.GetString("ACHI10");
        } else if (maxScore >= 50000 && achi[11] == "FALSE") {
            PlayerPrefs.SetString("ACHI11", "TRUE");
            achi[11] = PlayerPrefs.GetString("ACHI11");
        } else if (maxScore >= 100000 && achi[12] == "FALSE") {
            PlayerPrefs.SetString("ACHI12", "TRUE");
            achi[12] = PlayerPrefs.GetString("ACHI12");

        } else if (allScore >= 200000 && achi[13] == "FALSE") {
            PlayerPrefs.SetString("ACHI13", "TRUE");
            achi[13] = PlayerPrefs.GetString("ACHI13");
        } else if (allScore >= 300000 && achi[14] == "FALSE") {
            PlayerPrefs.SetString("ACHI14", "TRUE");
            achi[14] = PlayerPrefs.GetString("ACHI14");
        } else if (maxScore >= 500000 && achi[15] == "FALSE") {
            PlayerPrefs.SetString("ACHI15", "TRUE");
            achi[15] = PlayerPrefs.GetString("ACHI15");

        } else if (startCount >= 2 && achi[16] == "FALSE") {
            PlayerPrefs.SetString("ACHI16", "TRUE");
            achi[16] = PlayerPrefs.GetString("ACHI16");
        } else if (startCount >= 3 && achi[17] == "FALSE") {
            PlayerPrefs.SetString("ACHI17", "TRUE");
            achi[17] = PlayerPrefs.GetString("ACHI17");
        } else if (startCount >= 4 && achi[18] == "FALSE") {
            PlayerPrefs.SetString("ACHI18", "TRUE");
            achi[18] = PlayerPrefs.GetString("ACHI18");

        } else if (rare == 1 && achi[19] == "FALSE") {
            PlayerPrefs.SetString("ACHI19", "TRUE");
            achi[19] = PlayerPrefs.GetString("ACHI19");
        } else if (sRare == 1 && achi[20] == "FALSE") {
            PlayerPrefs.SetString("ACHI20", "TRUE");
            achi[20] = PlayerPrefs.GetString("ACHI20");

        } else if (credit == 1 && achi[21] == "FALSE") {
            PlayerPrefs.SetString("ACHI21", "TRUE");
            achi[21] = PlayerPrefs.GetString("ACHI21");
        } else if (damageCount >= 500000 && achi[22] == "FALSE") {
            PlayerPrefs.SetString("ACHI22", "TRUE");
            achi[22] = PlayerPrefs.GetString("ACHI22");
        } else if (_void == 1 && achi[23] == "FALSE") {
            PlayerPrefs.SetString("ACHI23", "TRUE");
            achi[23] = PlayerPrefs.GetString("ACHI23");
        } else if (gandhi == 1 && achi[24] == "FALSE") {
            PlayerPrefs.SetString("ACHI24", "TRUE");
            achi[24] = PlayerPrefs.GetString("ACHI24");
        }
    }
}
