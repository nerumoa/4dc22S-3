using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochiManager : MonoBehaviour
{
    [SerializeField] private GameObject Mochi;
    // Start is called before the first frame update
    void Start()
    {
        GameObject n = transform.GetChild(0).gameObject;
        GameObject r = transform.GetChild(1).gameObject;
        GameObject sr = transform.GetChild(2).gameObject;

        int rnd = Random.Range(0, 10);

        if (rnd == 9)
        {
            sr.SetActive(true);
        }

        else if (rnd == 0 || rnd == 5 || rnd == 3)
        {
            r.SetActive(true);
        }

        else
        {
            n.SetActive(true);
        }


    }

}