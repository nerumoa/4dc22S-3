using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour

{
    public void SCTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void SCGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void SCMusic()
    {
        SceneManager.LoadScene("MusicScene");
    }
    public void SCCredit()
    {
        SceneManager.LoadScene("CreditScene");
    }
    public void SCClear()
    {
        SceneManager.LoadScene("GameClearScene");
    }

    public void SCAchievement()
    {
        SceneManager.LoadScene("Achievement1Scene");
    }

    public void ExitApp()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
