using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Message : MonoBehaviour
{
    public TextMeshProUGUI ShowMessage;


    // Start is called before the first frame update
    void Start()
    {
        int rnd = Random.Range(1, 15);

        if (rnd == 1) ShowMessage.text = "薄暗い色なのは...臼くらいw";

        else if (rnd == 2) ShowMessage.text = "うすうす気づいてたんですよね・・・臼にｗ";

        else if (rnd == 3) ShowMessage.text = "餅の...モチーフｗ";

        else if (rnd == 4) ShowMessage.text = "二兎を追う者は一兎をも得ず";

        else if (rnd == 5) ShowMessage.text = "餅は餅屋";

        else if (rnd == 6) ShowMessage.text = "棚から牡丹餅";

        else if (rnd == 7) ShowMessage.text = "持ちのいい餅ｗ";

        else if (rnd == 8) ShowMessage.text = "止まない雨はない 開けない夜はない 搗けない餅はない";

        else if (rnd == 9) ShowMessage.text = "窮兎、人を噛む";

        else if (rnd == 10) ShowMessage.text = "明日は明日の餅をつく";

        else if (rnd == 11) ShowMessage.text = "The mochi is money";

        else if (rnd == 12) ShowMessage.text = "何もしないで後悔するより、餅をついて後悔するほうが良い";

        else if (rnd == 13) ShowMessage.text = "お餅をお持ちでない！？";






    }

    
}
