using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenuLevel1 : MonoBehaviour
{
    //public void NextLevel()
    //{
    //    SceneManager.LoadScene("Level 2");
    //}

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
