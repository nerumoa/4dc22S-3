using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] GameObject HP3 = default;
    [SerializeField] GameObject HP2 = default;
    [SerializeField] GameObject HP1 = default;

    GameObject button;
    ButtonManager bm;
    SpriteRenderer sr;

    float time;
    float cycle = 1f;
    int hp;

    private void Awake()
    {
        button = transform.parent.gameObject;
        bm = button.GetComponent<ButtonManager>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        int hp = bm.GetHP();
        if (hp == 2) {
            if (gameObject.name == "HP3") {
                //Destroy();
            }
        } else if (hp == 1) {
            if (gameObject.name == "HP2") {
                //Destroy();
            }
        } else if (hp == 0) {
            if (gameObject.name == "HP1") {
                //Destroy();
            }
        }

        /*
        time += Time.deltaTime;
        time %= 1.0f;
        var color = _target.color;
        color.a = time >= cycle * 0.5f ? 1 : 0;
        _target.color = color;
        */

    }
}
