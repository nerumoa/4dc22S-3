using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] int disapHP = default;     // è¡ñ≈Ç∑ÇÈHP

    GameObject button;
    ButtonManager bm;
    SpriteRenderer sr;

    float time;
    float cycle = 1f;
    int hp = 3;

    private void Awake()
    {
        button = transform.root.gameObject;
        bm = button.GetComponent<ButtonManager>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //Debug.Log("aaaa");

        if (hp != bm.GetHP()) {
            flash();
        }

        time += Time.deltaTime;
        time %= 1.0f;
    }

    IEnumerator flash()
    {
        for (int i = 0; i < 50; i++) {
            if (disapHP == bm.GetHP()) {
                var color = sr.color;
                color.a = time >= cycle * 0.5f ? 1 : 0;
                sr.color = color;
            }
            yield return new WaitForSeconds(0.01f);
        }
        hp = bm.GetHP();
    }
}
