using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultsButtons : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("ComedyClubStage");
    }

    public void Done()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
