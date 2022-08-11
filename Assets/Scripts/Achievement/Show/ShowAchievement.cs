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
    AudioSource audio;
    TextMeshProUGUI tmp;
    SpriteRenderer sp;

    bool cold = false;
    string[] achi = new string[26];

    private void Awake()
    {
        stac = GetComponent<ShowTextAchievement>();
        siac = GetComponent<ShowIconAchievement>();
        audio = GetComponent<AudioSource>();
        tmp = text2.GetComponent<TextMeshProUGUI>();
        sp = icon.GetComponent<SpriteRenderer>();        
    }

    void Update()
    {
        for (int i = 1; i <= 25; i++) {
            achi[i] = PlayerPrefs.GetString("ACHI" + i, "FALSE");
        }

        if (!cold) {
            if (achi[1] == "TRUE") {
                Achievement1();
            } else if (achi[2] == "TRUE") {
                Achievement2();
            } else if (achi[3] == "TRUE") {
                Achievement3();

            } else if (achi[4] == "TRUE") {
                Achievement4();
            } else if (achi[5] == "TRUE") {
                Achievement5();
            } else if (achi[6] == "TRUE") {
                Achievement6();

            } else if (achi[7] == "TRUE") {
                Achievement7();
            } else if (achi[8] == "TRUE") {
                Achievement8();
            } else if (achi[9] == "TRUE") {
                Achievement9();

            } else if (achi[10] == "TRUE") {
                Achievement10();
            } else if (achi[11] == "TRUE") {
                Achievement11();
            } else if (achi[12] == "TRUE") {
                Achievement12();

            } else if (achi[13] == "TRUE") {
                Achievement13();
            } else if (achi[14] == "TRUE") {
                Achievement14();
            } else if (achi[15] == "TRUE") {
                Achievement15();

            } else if (achi[16] == "TRUE") {
                Achievement16();
            } else if (achi[17] == "TRUE") {
                Achievement17();
            } else if (achi[18] == "TRUE") {
                Achievement18();

            } else if (achi[19] == "TRUE") {
                Achievement19();
            } else if (achi[20] == "TRUE") {
                Achievement20();

            } else if (achi[21] == "TRUE") {
                Achievement21();
            } else if (achi[22] == "TRUE") {
                Achievement22();
            } else if (achi[23] == "TRUE") {
                Achievement23();
            } else if (achi[24] == "TRUE") {
                Achievement24();

            } else if (achi[25] == "TRUE") {
                Achievement25();
            }
        }

        if (Input.GetKeyDown("k")) {
            for (int i = 1; i <= 24; i++) {
                PlayerPrefs.SetString("ACHI" + i, "FINISH");
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
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement11()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI11", "FINISH");
        tmp.text = stac.GetText11();
        sp.sprite = siac.GetIcon11();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement12()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI12", "FINISH");
        tmp.text = stac.GetText12();
        sp.sprite = siac.GetIcon12();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement13()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI13", "FINISH");
        tmp.text = stac.GetText13();
        sp.sprite = siac.GetIcon13();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement14()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI14", "FINISH");
        tmp.text = stac.GetText14();
        sp.sprite = siac.GetIcon14();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement15()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI15", "FINISH");
        tmp.text = stac.GetText15();
        sp.sprite = siac.GetIcon15();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement16()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI16", "FINISH");
        tmp.text = stac.GetText16();
        sp.sprite = siac.GetIcon16();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement17()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI17", "FINISH");
        tmp.text = stac.GetText17();
        sp.sprite = siac.GetIcon17();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement18()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI18", "FINISH");
        tmp.text = stac.GetText18();
        sp.sprite = siac.GetIcon18();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement19()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI19", "FINISH");
        tmp.text = stac.GetText19();
        sp.sprite = siac.GetIcon19();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement20()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI20", "FINISH");
        tmp.text = stac.GetText20();
        sp.sprite = siac.GetIcon20();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement21()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI21", "FINISH");
        tmp.text = stac.GetText21();
        sp.sprite = siac.GetIcon21();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement22()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI22", "FINISH");
        tmp.text = stac.GetText22();
        sp.sprite = siac.GetIcon22();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement23()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI23", "FINISH");
        tmp.text = stac.GetText23();
        sp.sprite = siac.GetIcon23();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement24()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI24", "FINISH");
        tmp.text = stac.GetText24();
        sp.sprite = siac.GetIcon24();
        icon.transform.localScale = new Vector2(1.25f, 1.25f);
        StartCoroutine("ShowAchieve");
    }

    public void Achievement25()
    {
        StartCoroutine("ColdAchieve");
        PlayerPrefs.SetString("ACHI25", "FINISH");
        tmp.text = stac.GetText25();
        sp.sprite = siac.GetIcon25();
        icon.transform.localScale = new Vector2(0.25f, 0.25f);
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
        for (int i = 0; i < 50; i++) {
            panel.transform.Translate(0f, -0.02f, 0f);
            icon.transform.Translate(0f, -0.02f, 0f);
            text.transform.Translate(0f, -2.0f, 0f);
            text2.transform.Translate(0f, -2.0f, 0f);
            yield return new WaitForSeconds(0.01f);
        }
        audio.Play();
        for (int i = 0; i < 50; i++) {
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
