using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    [SerializeField] int disapHP = default;     // è¡ñ≈Ç∑ÇÈHP

    GameObject button;
    ButtonManager bm;
    SpriteRenderer sr;

    int hp = 3;

    private void Awake()
    {
        button = transform.root.gameObject;
        bm = button.GetComponent<ButtonManager>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (hp != bm.GetHP()) {
            hp = bm.GetHP();
            StartCoroutine("flash");
        }
    }

    IEnumerator flash()
    {
        if (hp == disapHP) {
            for (int i = 0; i < 10; i++) {
                sr.enabled = !sr.enabled;
                yield return new WaitForSeconds(0.1f);
            }
            Destroy(gameObject);
        }
    }
}
