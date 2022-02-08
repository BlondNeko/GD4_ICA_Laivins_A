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
        SceneManager.LoadScene("Game");
        SceneManager.UnloadSceneAsync("MainMenu");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
