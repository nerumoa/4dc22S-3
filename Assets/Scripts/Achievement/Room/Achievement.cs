using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Achievement : MonoBehaviour
{
    [SerializeField] GameObject text = default;
    [SerializeField] GameObject icon = default;

    TextMeshProUGUI achiText;
    TextMeshProUGUI titleText;
    GameObject achievement;
    GameObject title;
    SpriteRenderer sr;
    NotOpenAchievement noa;
    TitleTextAchievement tta;
    OpenTextAchievement ota;
    ShowIconAchievement sia;
    string[] achi = new string[25];

    void Awake()
    {
        achiText = text.GetComponent<TextMeshProUGUI>();
        sr = icon.GetComponent<SpriteRenderer>();
        achievement = GameObject.Find("Achievement");
        sia = achievement.GetComponent<ShowIconAchievement>();
        noa = GetComponent<NotOpenAchievement>();
        tta = GetComponent<TitleTextAchievement>();
        ota = GetComponent<OpenTextAchievement>();
        titleText = transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        title = titleText.gameObject;
    }

    private void Start()
    {
        GetAchiRecord();
        GetTitleText();
    }

    private void GetAchiRecord()
    {
        for (int i = 1; i <= 24; i++) {
            achi[i] = PlayerPrefs.GetString("ACHI" + i, "FALSE");
        }
    }

    private void GetTitleText()
    {
        if (achi[1] == "FINISH" && title.name == "Text1") {
            titleText.text = tta.GetTitleText1();
        }
        if (achi[2] == "FINISH" && title.name == "Text2") {
            titleText.text = tta.GetTitleText2();
        }
        if (achi[3] == "FINISH" && title.name == "Text3") {
            titleText.text = tta.GetTitleText3();
        }

        if (achi[4] == "FINISH" && title.name == "Text4") {
            titleText.text = tta.GetTitleText4();
        }
        if (achi[5] == "FINISH" && title.name == "Text5") {
            titleText.text = tta.GetTitleText5();
        }
        if (achi[6] == "FINISH" && title.name == "Text6") {
            titleText.text = tta.GetTitleText6();
        }

        if (achi[7] == "FINISH" && title.name == "Text7") {
            titleText.text = tta.GetTitleText7();
        }
        if (achi[8] == "FINISH" && title.name == "Text8") {
            titleText.text = tta.GetTitleText8();
        }
        if (achi[9] == "FINISH" && title.name == "Text9") {
            titleText.text = tta.GetTitleText9();
        }

        if (achi[10] == "FINISH" && title.name == "Text10") {
            titleText.text = tta.GetTitleText10();
        }
        if (achi[11] == "FINISH" && title.name == "Text11") {
            titleText.text = tta.GetTitleText11();
        }
        if (achi[12] == "FINISH" && title.name == "Text12") {
            titleText.text = tta.GetTitleText12();
        }

        if (achi[13] == "FINISH" && title.name == "Text13") {
            titleText.text = tta.GetTitleText13();
        }
        if (achi[14] == "FINISH" && title.name == "Text14") {
            titleText.text = tta.GetTitleText14();
        }
        if (achi[15] == "FINISH" && title.name == "Text15") {
            titleText.text = tta.GetTitleText15();
        }

        if (achi[16] == "FINISH" && title.name == "Text16") {
            titleText.text = tta.GetTitleText16();
        }
        if (achi[17] == "FINISH" && title.name == "Text17") {
            titleText.text = tta.GetTitleText17();
        }
        if (achi[18] == "FINISH" && title.name == "Text18") {
            titleText.text = tta.GetTitleText18();
        }

        if (achi[19] == "FINISH" && title.name == "Text19") {
            titleText.text = tta.GetTitleText19();
        }
        if (achi[20] == "FINISH" && title.name == "Text20") {
            titleText.text = tta.GetTitleText20();
        }

        if (achi[21] == "FINISH" && title.name == "Text21") {
            titleText.text = tta.GetTitleText21();
        }
        if (achi[22] == "FINISH" && title.name == "Text22") {
            titleText.text = tta.GetTitleText22();
        }
        if (achi[23] == "FINISH" && title.name == "Text23") {
            titleText.text = tta.GetTitleText23();
        }
        if (achi[24] == "FINISH" && title.name == "Text24") {
            titleText.text = tta.GetTitleText24();
        }

        if (title.name == "Text25") {
            titleText.text = tta.GetTitleText25();
        }
    }

    public void Achievement1()
    {
        if (achi[1] != "FINISH") {
            achiText.text = noa.GetNotOpen1();
        } else {
            achiText.text = ota.GetOpenText1();
            sr.sprite = sia.GetIcon1();
        }
    }

    public void Achievement2()
    {
        if (achi[2] != "FINISH") {
            achiText.text = noa.GetNotOpen2();
        } else {
            achiText.text = ota.GetOpenText2();
            sr.sprite = sia.GetIcon2();
        }
    }

    public void Achievement3()
    {
        if (achi[3] != "FINISH") {
            achiText.text = noa.GetNotOpen3();
        } else {
            achiText.text = ota.GetOpenText3();
            sr.sprite = sia.GetIcon3();
        }
    }

    public void Achievement4()
    {
        if (achi[4] != "FINISH") {
            achiText.text = noa.GetNotOpen4();
        } else {
            achiText.text = ota.GetOpenText4();
            sr.sprite = sia.GetIcon4();
        }
    }

    public void Achievement5()
    {
        if (achi[5] != "FINISH") {
            achiText.text = noa.GetNotOpen5();
        } else {
            achiText.text = ota.GetOpenText5();
            sr.sprite = sia.GetIcon5();
        }
    }

    public void Achievement6()
    {
        if (achi[6] != "FINISH") {
            achiText.text = noa.GetNotOpen6();
        } else {
            achiText.text = ota.GetOpenText6();
            sr.sprite = sia.GetIcon6();
        }
    }

    public void Achievement7()
    {
        if (achi[7] != "FINISH") {
            achiText.text = noa.GetNotOpen7();
        } else {
            achiText.text = ota.GetOpenText7();
            sr.sprite = sia.GetIcon7();
        }
    }

    public void Achievement8()
    {
        if (achi[8] != "FINISH") {
            achiText.text = noa.GetNotOpen8();
        } else {
            achiText.text = ota.GetOpenText8();
            sr.sprite = sia.GetIcon8();
        }
    }

    public void Achievement9()
    {
        if (achi[9] != "FINISH") {
            achiText.text = noa.GetNotOpen9();
        } else {
            achiText.text = ota.GetOpenText9();
            sr.sprite = sia.GetIcon9();
        }
    }

    public void Achievement10()
    {
        if (achi[10] != "FINISH") {
            achiText.text = noa.GetNotOpen10();
        } else {
            achiText.text = ota.GetOpenText10();
            sr.sprite = sia.GetIcon10();
        }
    }

    public void Achievement11()
    {
        if (achi[11] != "FINISH") {
            achiText.text = noa.GetNotOpen11();
        } else {
            achiText.text = ota.GetOpenText11();
            sr.sprite = sia.GetIcon11();
        }
    }

    public void Achievement12()
    {
        if (achi[12] != "FINISH") {
            achiText.text = noa.GetNotOpen12();
        } else {
            achiText.text = ota.GetOpenText12();
            sr.sprite = sia.GetIcon12();
        }
    }

    public void Achievement13()
    {
        if (achi[13] != "FINISH") {
            achiText.text = noa.GetNotOpen13();
        } else {
            achiText.text = ota.GetOpenText13();
            sr.sprite = sia.GetIcon13();
        }
    }

    public void Achievement14()
    {
        if (achi[14] != "FINISH") {
            achiText.text = noa.GetNotOpen14();
        } else {
            achiText.text = ota.GetOpenText14();
            sr.sprite = sia.GetIcon14();
        }
    }

    public void Achievement15()
    {
        if (achi[15] != "FINISH") {
            achiText.text = noa.GetNotOpen15();
        } else {
            achiText.text = ota.GetOpenText15();
            sr.sprite = sia.GetIcon15();
        }
    }

    public void Achievement16()
    {
        if (achi[16] != "FINISH") {
            achiText.text = noa.GetNotOpen16();
        } else {
            achiText.text = ota.GetOpenText16();
            sr.sprite = sia.GetIcon16();
        }
    }

    public void Achievement17()
    {
        if (achi[17] != "FINISH") {
            achiText.text = noa.GetNotOpen17();
        } else {
            achiText.text = ota.GetOpenText17();
            sr.sprite = sia.GetIcon17();
        }
    }

    public void Achievement18()
    {
        if (achi[18] != "FINISH") {
            achiText.text = noa.GetNotOpen18();
        } else {
            achiText.text = ota.GetOpenText18();
            sr.sprite = sia.GetIcon18();
        }
    }

    public void Achievement19()
    {
        if (achi[19] != "FINISH") {
            achiText.text = noa.GetNotOpen19();
        } else {
            achiText.text = ota.GetOpenText19();
            sr.sprite = sia.GetIcon19();
        }
    }

    public void Achievement20()
    {
        if (achi[20] != "FINISH") {
            achiText.text = noa.GetNotOpen20();
        } else {
            achiText.text = ota.GetOpenText20();
            sr.sprite = sia.GetIcon20();
        }
    }

    public void Achievement21()
    {
        if (achi[21] != "FINISH") {
            achiText.text = noa.GetNotOpen21();
        } else {
            achiText.text = ota.GetOpenText21();
            sr.sprite = sia.GetIcon21();
        }
    }

    public void Achievement22()
    {
        if (achi[22] != "FINISH") {
            achiText.text = noa.GetNotOpen22();
        } else {
            achiText.text = ota.GetOpenText22();
            sr.sprite = sia.GetIcon22();
        }
    }

    public void Achievement23()
    {
        if (achi[23] != "FINISH") {
            achiText.text = noa.GetNotOpen23();
        } else {
            achiText.text = ota.GetOpenText23();
            sr.sprite = sia.GetIcon23();
        }
    }

    public void Achievement24()
    {
        if (achi[24] != "FINISH") {
            achiText.text = noa.GetNotOpen24();
        } else {
            achiText.text = ota.GetOpenText24();
            sr.sprite = sia.GetIcon24();
        }
    }

    public void Achievement25()
    {
        achiText.text = ota.GetOpenText25();
        sr.sprite = sia.GetIcon20();
    }
}
