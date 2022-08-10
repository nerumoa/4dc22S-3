using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleControll : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Single);
    }
}
