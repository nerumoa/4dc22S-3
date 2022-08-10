using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    public TextMeshProUGUI CountText;
    public float CountDownTime;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
        CountDownTime -= Time.deltaTime;

        seconds = (int)CountDownTime;

        CountText.text = seconds.ToString();
        

        if(seconds == 0)
        {
            Destroy(gameObject);
        }
    }
}
