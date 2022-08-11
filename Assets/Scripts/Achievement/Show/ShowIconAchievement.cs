using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowIconAchievement : MonoBehaviour
{
    [SerializeField] Sprite achi1Sprite = default;
    [SerializeField] Sprite achi2Sprite = default;
    [SerializeField] Sprite achi3Sprite = default;

    public Sprite GetIcon1()
    {
        return achi1Sprite;
    }

    public Sprite GetIcon2()
    {
        return achi2Sprite;
    }

    public Sprite GetIcon3()
    {
        return achi3Sprite;
    }
}
