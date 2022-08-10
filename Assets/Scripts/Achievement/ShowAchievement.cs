using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAchievement : MonoBehaviour
{
    [SerializeField] GameObject panel = default;
    [SerializeField] GameObject icon = default;
    [SerializeField] GameObject text = default;
    [SerializeField] GameObject text2 = default;

    int score;

    void Start()
    {
        score = PlayerPrefs.GetInt("SCORE", 0);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("SCORE", score);
        PlayerPrefs.Save();
    }

    void Update()
    {
        if (Input.GetKeyDown("p")) {
            StartCoroutine("ShowAchieve");
        }

        if (Input.GetKeyDown("o")) {
            Debug.Log(score);
        }
    }

    IEnumerator ShowAchieve()
    {
        for (int i = 0; i < 100; i++) {
            panel.transform.Translate(0f, -0.02f, 0f);
            icon.transform.Translate(0f, -0.02f, 0f);
            text.transform.Translate(0f, -2.0f, 0f);
            text2.transform.Translate(0f, -2.0f, 0f);
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < 100; i++) {
            panel.transform.Translate(0f, 0.02f, 0f);
            icon.transform.Translate(0f, 0.02f, 0f);
            text.transform.Translate(0f, 2.0f, 0f);
            text2.transform.Translate(0f, 2.0f, 0f);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
