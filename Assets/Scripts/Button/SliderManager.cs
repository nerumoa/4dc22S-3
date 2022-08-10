using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    Slider slider;
    GameObject button;
    ButtonManager bm;

    // Start is called before the first frame update
    void Awake()
    {
        button = transform.root.gameObject;
        slider = GetComponent<Slider>();
        bm = button.GetComponent<ButtonManager>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = bm.GetTimerMax();
        slider.value = bm.GetTimer();
    }
}
