using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Achievement : MonoBehaviour
{
    [SerializeField] GameObject text = default;
    TextMeshProUGUI achiText;
    TextMeshProUGUI titleText;
    GameObject title;
    NotOpenAchievement noa;
    TitleTextAchievement tta;
    string achi1, achi2, achi3, achi4, achi5, achi6, achi7, achi8;
    string achi9, achi10, achi11, achi12, achi13, achi14, achi15, achi16;
    string achi17, achi18, achi19, achi20, achi21, achi22, achi23, achi24;

    void Awake()
    {
        achiText = text.GetComponent<TextMeshProUGUI>();
        noa = GetComponent<NotOpenAchievement>();
        tta = GetComponent<TitleTextAchievement>();
        titleText = transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        title = titleText.gameObject;
    }

    private void Start()
    {
        GetAchiRecord();

        if (achi1 == "FINISH" && title.name == "Text1") {
            titleText.text = tta.GetTitleText1();
        }
        if (achi2 == "FINISH" && title.name == "Text2") {
            titleText.text = tta.GetTitleText2();
        }
        if (achi3 == "FINISH" && title.name == "Text3") {
            titleText.text = tta.GetTitleText3();
        }

        if (achi4 == "FINISH" && title.name == "Text4") {
            titleText.text = tta.GetTitleText4();
        }
        if (achi5 == "FINISH" && title.name == "Text5") {
            titleText.text = tta.GetTitleText5();
        }
        if (achi6 == "FINISH" && title.name == "Text6") {
            titleText.text = tta.GetTitleText6();
        }

        if (achi7 == "FINISH" && title.name == "Text7") {
            titleText.text = tta.GetTitleText7();
        }
        if (achi8 == "FINISH" && title.name == "Text8") {
            titleText.text = tta.GetTitleText8();
        }
        if (achi9 == "FINISH" && title.name == "Text9") {
            titleText.text = tta.GetTitleText9();
        }

        if (achi10 == "FINISH" && title.name == "Text10") {
            titleText.text = tta.GetTitleText10();
        }
        if (achi11 == "FINISH" && title.name == "Text11") {
            titleText.text = tta.GetTitleText11();
        }
        if (achi12 == "FINISH" && title.name == "Text12") {
            titleText.text = tta.GetTitleText12();
        }

        if (achi13 == "FINISH" && title.name == "Text13") {
            titleText.text = tta.GetTitleText13();
        }
        if (achi14 == "FINISH" && title.name == "Text14") {
            titleText.text = tta.GetTitleText14();
        }
        if (achi15 == "FINISH" && title.name == "Text15") {
            titleText.text = tta.GetTitleText15();
        }

        if (achi16 == "FINISH" && title.name == "Text16") {
            titleText.text = tta.GetTitleText16();
        }
        if (achi17 == "FINISH" && title.name == "Text17") {
            titleText.text = tta.GetTitleText17();
        }
        if (achi18 == "FINISH" && title.name == "Text18") {
            titleText.text = tta.GetTitleText18();
        }

        if (achi19 == "FINISH" && title.name == "Text19") {
            titleText.text = tta.GetTitleText19();
        }
        if (achi20 == "FINISH" && title.name == "Text20") {
            titleText.text = tta.GetTitleText20();
        }

        if (achi21 == "FINISH" && title.name == "Text21") {
            titleText.text = tta.GetTitleText21();
        }
        if (achi22 == "FINISH" && title.name == "Text22") {
            titleText.text = tta.GetTitleText22();
        }
        if (achi23 == "FINISH" && title.name == "Text23") {
            titleText.text = tta.GetTitleText23();
        }
        if (achi24 == "FINISH" && title.name == "Text24") {
            titleText.text = tta.GetTitleText24();
        }
    }

    private void GetAchiRecord()
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

        achi16 = PlayerPrefs.GetString("ACHI16", "FALSE");
        achi17 = PlayerPrefs.GetString("ACHI17", "FALSE");
        achi18 = PlayerPrefs.GetString("ACHI18", "FALSE");

        achi19 = PlayerPrefs.GetString("ACHI19", "FALSE");
        achi20 = PlayerPrefs.GetString("ACHI20", "FALSE");

        achi21 = PlayerPrefs.GetString("ACHI21", "FALSE");
        achi22 = PlayerPrefs.GetString("ACHI22", "FALSE");
        achi23 = PlayerPrefs.GetString("ACHI23", "FALSE");
        achi24 = PlayerPrefs.GetString("ACHI24", "FALSE");
    }

    public void Achievement1()
    {
        if (achi1 != "FINISH") {
            achiText.text = noa.GetNotOpen1();
        } else {
            achiText.text = "餅を10000回搗くと取得。\n餅つきマスターの証。";
        }
    }

    public void Achievement2()
    {
        if (achi2 != "FINISH") {
            achiText.text = noa.GetNotOpen2();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement3()
    {
        if (achi3 != "FINISH") {
            achiText.text = noa.GetNotOpen3();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement4()
    {
        if (achi4 != "FINISH") {
            achiText.text = noa.GetNotOpen4();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement5()
    {
        if (achi5 != "FINISH") {
            achiText.text = noa.GetNotOpen5();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement6()
    {
        if (achi6 != "FINISH") {
            achiText.text = noa.GetNotOpen6();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement7()
    {
        if (achi7 != "FINISH") {
            achiText.text = noa.GetNotOpen7();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement8()
    {
        if (achi8 != "FINISH") {
            achiText.text = noa.GetNotOpen8();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement9()
    {
        if (achi9 != "FINISH") {
            achiText.text = noa.GetNotOpen9();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement10()
    {
        if (achi10 != "FINISH") {
            achiText.text = noa.GetNotOpen10();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement11()
    {
        if (achi11 != "FINISH") {
            achiText.text = noa.GetNotOpen11();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement12()
    {
        if (achi12 != "FINISH") {
            achiText.text = noa.GetNotOpen12();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement13()
    {
        if (achi13 != "FINISH") {
            achiText.text = noa.GetNotOpen13();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement14()
    {
        if (achi14 != "FINISH") {
            achiText.text = noa.GetNotOpen14();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement15()
    {
        if (achi15 != "FINISH") {
            achiText.text = noa.GetNotOpen15();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement16()
    {
        if (achi16 != "FINISH") {
            achiText.text = noa.GetNotOpen16();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement17()
    {
        if (achi17 != "FINISH") {
            achiText.text = noa.GetNotOpen17();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement18()
    {
        if (achi18 != "FINISH") {
            achiText.text = noa.GetNotOpen18();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement19()
    {
        if (achi19 != "FINISH") {
            achiText.text = noa.GetNotOpen19();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement20()
    {
        if (achi20 != "FINISH") {
            achiText.text = noa.GetNotOpen20();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement21()
    {
        if (achi21 != "FINISH") {
            achiText.text = noa.GetNotOpen21();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement22()
    {
        if (achi22 != "FINISH") {
            achiText.text = noa.GetNotOpen22();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement23()
    {
        if (achi23 != "FINISH") {
            achiText.text = noa.GetNotOpen23();
        } else {
            achiText.text = "";
        }
    }

    public void Achievement24()
    {
        if (achi24 != "FINISH") {
            achiText.text = noa.GetNotOpen24();
        } else {
            achiText.text = "";
        }
    }
}
