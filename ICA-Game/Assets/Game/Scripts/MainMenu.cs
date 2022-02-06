using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // following tutorial from https://www.youtube.com/watch?v=RsgiYqLID-U 
    // button quits game
    public void QuitButton()
    {
        Application.Quit();
    }

    //button starts first scene
    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
