using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    [SerializeField] private GameObject BGMObject;

    public TextMeshProUGUI CountText;
    public float CountDownTime;
    public AudioClip CountDownSound;
    int seconds;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Soundcorutine());
    }

    // Update is called once per frame
    void Update()
    {
       
        CountDownTime -= Time.deltaTime;

        seconds = (int)CountDownTime;

        CountText.text = seconds.ToString();
        

        if(seconds == 0)
        {
            BGMObject.SetActive(true);

            Destroy(gameObject);
        }
    }
    //カウントダウンに合わせて効果音を出す
    IEnumerator Soundcorutine()
    {
        GetComponent<AudioSource>().PlayOneShot(CountDownSound);

        yield return new WaitForSeconds(1f);

        GetComponent<AudioSource>().PlayOneShot(CountDownSound);

        yield return new WaitForSeconds(1f);

        GetComponent<AudioSource>().PlayOneShot(CountDownSound);

    }
}
