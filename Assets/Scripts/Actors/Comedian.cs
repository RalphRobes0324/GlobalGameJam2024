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

    //Track of jokes being created
    public string comedianMakeJoke;
    private int lengthJoke;
    public bool doneMakingJoke;

    private void Start()
    {
        lengthJoke = comedianJokes.Length; //get length
        doneMakingJoke = false; //start creation
    }
    private void Update()
    {
        if (!doneMakingJoke) //checks joke is not made yet
        {
            comedianMakeJoke = GetJokeRandom(); //get Joke
        }
    }
    //Get Random jokes
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

    //Get Random position of index based on range
    private int RandomNum()
    {
        int pos = UnityEngine.Random.Range(0, lengthJoke);
        return pos;
    }
    
}
