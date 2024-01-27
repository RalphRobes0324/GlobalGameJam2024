using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Jobs;

public class Comedian : MonoBehaviour
{
    //Set up different type of joke
    private string[] comedianJokes = {
        "!", "@", "#", "$", "%", "^", "&",
        "*", "(", ")"
    }; 
    private string comedianMakeJoke; //This will display UI
    private string[] getJoke; //Get random joke that was selected 
   
    private int lengthJokes;
    private int giveJokeIndex;
    private int getJokeIndex;
    private void Start()
    {
        lengthJokes = comedianJokes.Length;  //
        giveJokeIndex = 0;
        getJokeIndex = 0;
        getJokeIndex = 0;
    }
    // Update is called once per frame
    private void Update()
    {
 

    }
}
