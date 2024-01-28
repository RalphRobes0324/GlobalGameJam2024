using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpScript : MonoBehaviour
{
    public void GoButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
