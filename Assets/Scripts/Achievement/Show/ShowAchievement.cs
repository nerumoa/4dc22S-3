using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowAchievement : MonoBehaviour
{
    [SerializeField] GameObject panel = default;
    [SerializeField] GameObject icon = default;
    [SerializeField] GameObject text = default;
    [SerializeField] GameObject text2 = default;

    ShowTextAchievement stac;
    ShowIconAchievement siac;
    TextMeshProUGUI tmp;
    SpriteRenderer sp;

    bool cold = false;
    string achi1, achi2, achi3;

    private void Awake()
    {
        stac = GetComponent<ShowTextAchievement>();
        siac = GetComponent<ShowIconAchievement>();
        tmp = text2.GetComponent<TextMeshProUGUI>();
        sp = icon.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        achi1 = PlayerPrefs.GetString("ACHI1", "FALSE");
        achi2 = PlayerPrefs.GetString("ACHI2", "FALSE");
        achi3 = PlayerPrefs.GetString("ACHI3", "FALSE");

        if (!cold) {
            if (achi1 == "TRUE") {
                Achievement1();
            } else if (achi2 == "TRUE") {
                Achievement2();
            } else if (achi3 == "TRUE") {
                Achievement3();
            }
        }
    }

    public void Achievement1()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI1", "FINISH");
        tmp.text = stac.GetText1();
        sp.sprite = siac.GetIcon1();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement2()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI2", "FINISH");
        tmp.text = stac.GetText2();
        sp.sprite = siac.GetIcon2();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement3()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI3", "FINISH");
        tmp.text = stac.GetText3();
        sp.sprite = siac.GetIcon3();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }



    IEnumerator ColdAchieve()
    {
        cold = true;
        yield return new WaitForSeconds(7.0f);
        cold = false;
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
