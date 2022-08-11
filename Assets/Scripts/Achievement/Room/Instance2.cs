using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instance2 : Singleton2<Instance2>
{
    void Awake()
    {
        if (this != Instance2) {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "TitleScene") {
            Destroy(gameObject);
        }
    }
}
