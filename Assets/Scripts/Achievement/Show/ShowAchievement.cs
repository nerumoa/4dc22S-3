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
    string achi1, achi2, achi3, achi4, achi5, achi6, achi7, achi8, achi9, achi10;
    string achi11, achi12, achi13, achi14, achi15, achi16, achi17, achi18, achi19;

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

        if (!cold) {
            if (achi1 == "TRUE") {
                Achievement1();
            } else if (achi2 == "TRUE") {
                Achievement2();
            } else if (achi3 == "TRUE") {
                Achievement3();

            } else if (achi4 == "TRUE") {
                Achievement4();
            } else if (achi5 == "TRUE") {
                Achievement5();
            } else if (achi6 == "TRUE") {
                Achievement6();

            } else if (achi7 == "TRUE") {
                Achievement7();
            } else if (achi8 == "TRUE") {
                Achievement8();
            } else if (achi9 == "TRUE") {
                Achievement9();

            } else if (achi10 == "TRUE") {
                Achievement10();
            } else if (achi11 == "TRUE") {
                Achievement11();
            } else if (achi12 == "TRUE") {
                Achievement12();

            } else if (achi13 == "TRUE") {
                Achievement13();
            } else if (achi14 == "TRUE") {
                Achievement14();
            } else if (achi15 == "TRUE") {
                Achievement15();
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

    public void Achievement4()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI4", "FINISH");
        tmp.text = stac.GetText4();
        sp.sprite = siac.GetIcon4();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement5()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI5", "FINISH");
        tmp.text = stac.GetText5();
        sp.sprite = siac.GetIcon5();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement6()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI6", "FINISH");
        tmp.text = stac.GetText6();
        sp.sprite = siac.GetIcon6();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement7()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI7", "FINISH");
        tmp.text = stac.GetText7();
        sp.sprite = siac.GetIcon7();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement8()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI8", "FINISH");
        tmp.text = stac.GetText8();
        sp.sprite = siac.GetIcon8();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement9()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI9", "FINISH");
        tmp.text = stac.GetText9();
        sp.sprite = siac.GetIcon9();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement10()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI10", "FINISH");
        tmp.text = stac.GetText10();
        sp.sprite = siac.GetIcon10();
        icon.transform.localScale = new Vector2(1f, 1f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement11()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI11", "FINISH");
        tmp.text = stac.GetText11();
        sp.sprite = siac.GetIcon11();
        icon.transform.localScale = new Vector2(1f, 1f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement12()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI12", "FINISH");
        tmp.text = stac.GetText12();
        sp.sprite = siac.GetIcon12();
        icon.transform.localScale = new Vector2(1f, 1f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement13()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI13", "FINISH");
        tmp.text = stac.GetText13();
        sp.sprite = siac.GetIcon13();
        icon.transform.localScale = new Vector2(1f, 1f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement14()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI14", "FINISH");
        tmp.text = stac.GetText14();
        sp.sprite = siac.GetIcon14();
        icon.transform.localScale = new Vector2(1f, 1f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement15()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI15", "FINISH");
        tmp.text = stac.GetText15();
        sp.sprite = siac.GetIcon15();
        icon.transform.localScale = new Vector2(1f, 1f);
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
