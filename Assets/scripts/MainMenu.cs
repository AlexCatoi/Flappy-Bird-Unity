using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Statistici()
    {
        SceneManager.LoadScene("Statistics");
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
}
