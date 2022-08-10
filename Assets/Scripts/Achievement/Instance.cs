using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : Singleton<Instance>
{
    void Awake()
    {
        if (this != Instance) {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
}
