using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Comedian : GameManager
{
    //Jokes Symbol
    private string[] jokes = { "!", "@",
    "#", "$", "%", "^", "&", "*", "(", ")"};
    private char[] calculateJokeChar; //calculating each symbol worth

	public Animator animator;

	//Main functions of Comedian
	public float finalJokeScore = 0.0f;
    public bool statusCo;
    public float countdownMinutes;

    //Get Audience Script and its variables
    GameObject audienceObject;
    GameObject gameManagerObject;
    GameManager gameManager;
    Audience audience;

	Player player;

	GameObject playerObject;

	int armSwinging = 0;

    //Starts when program begin
    private void Start()
    {
        //Getting Component
        audienceObject = GameObject.Find("obj_audienceManager");
        audience = audienceObject.GetComponent<Audience>();
        gameManagerObject = GameObject.Find("Game Manager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
        statusCo = true;

		playerObject = GameObject.Find("obj_player");
		player = playerObject.GetComponent<Player>();

		countdownMinutes = 60.0f;
    }
    //Update every frame
    private void Update()
    {
            if (gameManager.typeRound == 0) //Check Comedian is ready for a joke
            {
			    animator.SetBool("isStaring", false);
			    animator.SetBool("isTalking", true);
			    if (finalJokeScore <= 0.0f)
				{
					string comedianJoke = CreateJoke(); //Create joke
					finalJokeScore = GetScore(comedianJoke); // get Score
                    player.currentJokeScore = finalJokeScore; 
					statusCo = false; //Joke has been made
                    armSwinging = UnityEngine.Random.Range(0, 1);    if (armSwinging == 0) { animator.SetBool("armSwinging", false); }
                    else { animator.SetBool("armSwinging", true); }
				}

            }
            else //Checks for other conditions
            {
                //Checks if audience is done reacting to joke
                if (gameManager.typeRound == 1 && !audience.statusAudi)
                {
				    animator.SetBool("isTalking", false);
				    finalJokeScore = 0.0f; //reset score
                    statusCo = true; //start over again
                }
                if (gameManager.typeRound == 2)
                {
				    animator.SetBool("isStaring", true);
                    finalJokeScore = 0.0f;
				    statusCo = true; //start over again
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
            switch (c)
            {
                case '!':
                    finalJokeScore += (float)JokeScore.exclamationPoint;
                    break;
                case '@':
                    finalJokeScore += (float)JokeScore.atPoint;
                    break;
                case '#':
                    finalJokeScore += (float)JokeScore.hashPoint;
                    break;
                case '$':
                    finalJokeScore += (float)JokeScore.dollarPoint;
                    break;
                case '%':
                    finalJokeScore += (float)JokeScore.precentPoint;
                    break;
                case '^':
                    finalJokeScore += (float)JokeScore.powerPoint;
                    break;
                case '&':
                    finalJokeScore += (float)JokeScore.andPoint;
                    break;
                case '*':
                    finalJokeScore += (float)JokeScore.starPoint;
                    break;
                case '(':
                    finalJokeScore += (float)JokeScore.leftBracket;
                    break;
                default:
                    finalJokeScore += 0;
                    break;
           
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
