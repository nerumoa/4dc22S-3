using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAchievement : MonoBehaviour
{
    StartAchievement staa;
    ShowAchievement shoa;

    int startCount;
    string achi1;

    void Awake()
    {
        staa = GetComponent<StartAchievement>();
        shoa = GetComponent<ShowAchievement>();
        achi1 = PlayerPrefs.GetString("ACHI1", "FALSE");
    }

    private void OnDestroy()
    {
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        startCount = staa.GetStartCount();

        if (startCount == 4 && achi1 == "FALSE") {
            PlayerPrefs.SetString("ACHI1", "TRUE");
            achi1 = PlayerPrefs.GetString("ACHI1", "FALSE");
            shoa.Achievement1();
        }
    }
}
