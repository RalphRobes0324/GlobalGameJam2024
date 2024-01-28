using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
