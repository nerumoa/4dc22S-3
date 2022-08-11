using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBGM : MonoBehaviour
{
    [SerializeField] private GameObject BGM;
   


    // Start is called before the first frame update
    void Start()
    {
        GameObject spacemochi = transform.GetChild(0).gameObject;
        GameObject space = transform.GetChild(1).gameObject;

        int rnd = Random.Range(1, 11);

        if (rnd == 1)
        {
            space.SetActive(true);
        }
        else
        {
            spacemochi.SetActive(true);
        }
    }

}
