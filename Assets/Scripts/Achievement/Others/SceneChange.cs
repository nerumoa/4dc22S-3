using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ButtonExit()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void Button1_2()
    {
        SceneManager.LoadScene("Achievement2Scene");
    }

    public void Button2_1()
    {
        SceneManager.LoadScene("Achievement1Scene");
    }

    public void Button2_3()
    {
        SceneManager.LoadScene("Achievement3Scene");
    }

    public void Button3_2()
    {
        SceneManager.LoadScene("Achievement2Scene");
    }
}
