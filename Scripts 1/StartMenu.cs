using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu: MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
     
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void HelpButton()
    {
        SceneManager.LoadScene("HelpScene");
    }
}
