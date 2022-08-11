using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Achievement : MonoBehaviour
{
    [SerializeField] GameObject text = default;
    TextMeshProUGUI achiText;
    TextMeshProUGUI titleText;
    bool achi1, achi2, achi3, achi4, achi5, achi6, achi7, achi8;
    bool achi9, achi10, achi11, achi12, achi13, achi14, achi15, achi16;
    bool achi17, achi18, achi19, achi20, achi21, achi22, achi23, achi24;

    void Awake()
    {
        achiText = text.GetComponent<TextMeshProUGUI>();
        titleText = transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        // ShowAchievementと同じやり方でテキストを取る

        if (PlayerPrefs.GetString("ACHI1") == "FINISH") {
            if (titleText.gameObject.name == "Text1") {
                titleText.text = "止まない雨はない。開けない夜はない。搗けない餅はない。";
                titleText.fontSize = 37;
            }
        }
    }

    public void Achievement1()
    {
        if (PlayerPrefs.GetString("ACHI1") != "FINISH") {
            achiText.text = "これはテストです。これはテストです。これはテストです。";
        } else {
            achiText.text = "餅を10000回搗くと取得。\n餅つきマスターの証。";
        }
        
    }

    public void Achievement2()
    {
        achiText.text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbbsuhifueeiusdfuufhiue hiufenhiiinuh";
    }

    public void Achievement3()
    {
        achiText.text = "a";
    }

    public void Achievement4()
    {
        achiText.text = "b";
    }

    public void Achievement5()
    {
        achiText.text = "c";
    }

    public void Achievement6()
    {
        achiText.text = "d";
    }

    public void Achievement7()
    {
        achiText.text = "e";
    }

    public void Achievement8()
    {
        achiText.text = "f";
    }

    public void Achievement9()
    {
        achiText.text = "g";
    }

    public void Achievement10()
    {
        achiText.text = "h";
    }

    public void Achievement11()
    {
        achiText.text = "i";
    }

    public void Achievement12()
    {
        achiText.text = "j";
    }

    public void Achievement13()
    {
        achiText.text = "k";
    }

    public void Achievement14()
    {
        achiText.text = "l";
    }

    public void Achievement15()
    {
        achiText.text = "m";
    }

    public void Achievement16()
    {
        achiText.text = "n";
    }

    public void Achievement17()
    {
        achiText.text = "o";
    }

    public void Achievement18()
    {
        achiText.text = "p";
    }

    public void Achievement19()
    {
        achiText.text = "q";
    }

    public void Achievement20()
    {
        achiText.text = "r";
    }

    public void Achievement21()
    {
        achiText.text = "s";
    }

    public void Achievement22()
    {
        achiText.text = "t";
    }

    public void Achievement23()
    {
        achiText.text = "u";
    }

    public void Achievement24()
    {
        achiText.text = "v";
    }
}
