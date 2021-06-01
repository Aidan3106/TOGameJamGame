using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("AMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
