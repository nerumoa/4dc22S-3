using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    Slider slider;
    GameObject button;
    ButtonManager bm;

    void Awake()
    {
        button = transform.root.gameObject;
        slider = GetComponent<Slider>();
        bm = button.GetComponent<ButtonManager>();
    }

    void Update()
    {
        slider.maxValue = bm.GetTimerMax();
        slider.value = bm.GetTimer();
    }
}
