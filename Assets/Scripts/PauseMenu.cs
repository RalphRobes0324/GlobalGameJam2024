using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseScreen;

    public void Resume()
    {
        pauseScreen.SetActive(false); // close pause screen
    }

    public void Exit()
    {
        SceneManager.LoadScene("Main Menu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) // if user presses esc
        {
            if (pauseScreen.activeSelf == false) // check if pause screen is closed
            {
                pauseScreen.SetActive(true); // open pause menu
                Time.timeScale = 0f; // freeze objects
            }
            else
            {
                pauseScreen.SetActive(false); // close pause menu
                Time.timeScale = 1f; // unfreeze objects
            }
        }
    }
}