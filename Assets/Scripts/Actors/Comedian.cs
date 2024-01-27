using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

using UnityEngine.Jobs;

public class Comedian : GameManager
{
    //Set up different type of joke
    private string[] comedianJokes = {
        "!", "@", "#", "$", "%", "^", "&",
        "*", "(", ")"
    };


    private string comedianMakeJoke;
    private int lengthJoke;
    public bool doneMakingJoke;

    private void Start()
    {
        lengthJoke = comedianJokes.Length;
        doneMakingJoke = false;
    }
    private void Update()
    {
        if (doneMakingJoke)
        {
            Debug.Log(comedianMakeJoke);
        }
        else
        {
            comedianMakeJoke = GetJokeRandom();
            
        }
    }

    private string GetJokeRandom()
    {
        string joke;
        joke = comedianJokes[RandomNum()];
        joke += comedianJokes[RandomNum()];
        joke += comedianJokes[RandomNum()];
        joke += comedianJokes[RandomNum()];
        joke += comedianJokes[RandomNum()];
        joke += comedianJokes[RandomNum()];
        doneMakingJoke = true;
        return joke;
    }

    private int RandomNum()
    {
        int pos = UnityEngine.Random.Range(0, lengthJoke);
        return pos;
    }
    
}
