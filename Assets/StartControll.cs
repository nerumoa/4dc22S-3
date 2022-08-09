using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartControll : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }

}
