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

        if (rnd == 1) ShowMessage.text = "���Â��F�Ȃ̂�...�P���炢w";

        else if (rnd == 2) ShowMessage.text = "���������C�Â��Ă���ł���ˁE�E�E�P�ɂ�";

        else if (rnd == 3) ShowMessage.text = "�݂�...���`�[�t��";

        else if (rnd == 4) ShowMessage.text = "��e��ǂ��҂͈�e��������";

        else if (rnd == 5) ShowMessage.text = "�݂͖݉�";

        else if (rnd == 6) ShowMessage.text = "�I���牲�O��";

        else if (rnd == 7) ShowMessage.text = "�����̂����݂�";

        else if (rnd == 8) ShowMessage.text = "�~�܂Ȃ��J�͂Ȃ� �J���Ȃ���͂Ȃ� �����Ȃ��݂͂Ȃ�";

        else if (rnd == 9) ShowMessage.text = "���e�A�l������";

        else if (rnd == 10) ShowMessage.text = "�����͖����̖݂���";

        else if (rnd == 11) ShowMessage.text = "The mochi is money";

        else if (rnd == 12) ShowMessage.text = "�������Ȃ��Ō��������A�݂����Č������ق����ǂ�";

        else if (rnd == 13) ShowMessage.text = "���݂��������łȂ��I�H";






    }

    
}
