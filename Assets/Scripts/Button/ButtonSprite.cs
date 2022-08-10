using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSprite : MonoBehaviour
{
    [SerializeField] Sprite wSprite = default;
    [SerializeField] Sprite aSprite = default;
    [SerializeField] Sprite sSprite = default;
    [SerializeField] Sprite dSprite = default;
    [SerializeField] Sprite upSprite = default;
    [SerializeField] Sprite leftSprite = default;
    [SerializeField] Sprite downSprite = default;
    [SerializeField] Sprite rightSprite = default;
    [SerializeField] Sprite square = default;
    [SerializeField] int num = -1;

    SpriteRenderer sp;
    GameObject button;
    ButtonManager bm;

    private void Awake()
    {
        button = transform.parent.gameObject;
        sp = GetComponent<SpriteRenderer>();
        bm = button.GetComponent<ButtonManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bm.GetReqKey(num) == "W") {
            sp.sprite = wSprite;
        } else if (bm.GetReqKey(num) == "A") {
            sp.sprite = aSprite;
        } else if (bm.GetReqKey(num) == "S") {
            sp.sprite = sSprite;
        } else if (bm.GetReqKey(num) == "D") {
            sp.sprite = dSprite;
        } else if (bm.GetReqKey(num) == "UpArrow") {
            sp.sprite = upSprite;
        } else if (bm.GetReqKey(num) == "LeftArrow") {
            sp.sprite = leftSprite;
        } else if (bm.GetReqKey(num) == "DownArrow") {
            sp.sprite = downSprite;
        } else if (bm.GetReqKey(num) == "RightArrow") {
            sp.sprite = rightSprite;
        } else {
            if (sp.sprite != square) {
                sp.sprite = square;
            }
        }
    }
}
