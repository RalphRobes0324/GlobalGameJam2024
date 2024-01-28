using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class Comedian : GameManager
{
    //Jokes Symbol
    private string[] jokes = { "!", "@",
    "#", "$", "%", "^", "&", "*", "(", ")"};
    private char[] calculateJokeChar; //calculating each symbol worth



    //Main functions of Comedian
    private bool startTimer;
    public float finalJokeScore;
    public bool statusCo;
    public bool RoundStart;
    public float countdownMinutes;

    //Get Audience Script and its variables
    GameObject audienceObject;
    GameObject playerObject;
    GameObject gameManagerObject;
    Player player;
    GameManager gameManager;
    Audience audience;

    //Starts when program begin
    private void Start()
    {
        //Getting Component
        audienceObject = GameObject.Find("obj_Audience");
        audience = audienceObject.GetComponent<Audience>();
        gameManagerObject = GameObject.Find("Game Manager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
        playerObject = GameObject.Find("obj_Player");
        player = playerObject.GetComponent<Player>();
        statusCo = true;
        RoundStart = false;
        countdownMinutes = 60.0f;
    }
    //Update every frame
    private void Update()
    {
        //Check Round is done
        if (RoundStart)
        {
            if (statusCo) //Check Comedian is ready for a joke
            {
                string comedianJoke = CreateJoke(); //Create joke
                finalJokeScore = GetScore(comedianJoke); // get Score

                statusCo = false; //Joke has been made

            }
            else //Checks for other conditions
            {
                //Checks if audience is done reacting to joke
                if (!statusCo && !audience.statusAudi && !startTimer)
                {
                    finalJokeScore = 0.0f; //reset score
                    statusCo = true; //start over again
                }

            }
        }

    }

    /// <summary>
    /// Gets Total Score
    /// </summary>
    /// <param name="comedianJoke"></param>
    /// <returns></returns>
    private float GetScore(string comedianJoke)
    {
        calculateJokeChar = comedianJoke.ToCharArray();
        foreach (char c in calculateJokeChar)
        {
            if (c == '!')
            {
                finalJokeScore += (float)JokeScore.exclamationPoint;
            }
            else if (c == '@')
            {
                finalJokeScore += (float)JokeScore.atPoint;
            }
            else if (c == '#')
            {
                finalJokeScore += (float)JokeScore.hashPoint;
            }
            else if (c == '$')
            {
                finalJokeScore += (float)JokeScore.dollarPoint;
            }
            else if (c == '%')
            {
                finalJokeScore += (float)JokeScore.precentPoint;
            }
            else if (c == '^')
            {
                finalJokeScore += (float)JokeScore.powerPoint;
            }
            else if (c == '&')
            {
                finalJokeScore += (float)JokeScore.andPoint;
            }
            else if (c == '*')
            {
                finalJokeScore += (float)JokeScore.starPoint;
            }
            else if (c == '(')
            {
                finalJokeScore += (float)JokeScore.leftBracket;
            }
            else
            {
                finalJokeScore += 0;
            }
        }
        return finalJokeScore;
    }

    /// <summary>
    /// Creates for Comedian to make
    /// </summary>
    /// <returns></returns>
    private string CreateJoke()
    {
        string joke;
        joke = jokes[RandomPos()];
        joke += jokes[RandomPos()];
        joke += jokes[RandomPos()];
        joke += jokes[RandomPos()];
        joke += jokes[RandomPos()];
        joke += jokes[RandomPos()];
        return joke;
    }

    /// <summary>
    /// Gets Random position in the array
    /// </summary>
    /// <returns></returns>
    private int RandomPos()
    {
        int pos = UnityEngine.Random.Range(0, jokes.Length);
        return pos;

    }
}
