using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Creating Point system for each Symbol
    public enum JokeScore
    {
        exclamationPoint = 1, //! 
        atPoint = 2, //@ 
        hashPoint = 3, //# 
        dollarPoint = 4, // $
        precentPoint = 5, // %
        powerPoint = 6, // ^
        andPoint = 7, // &
        starPoint = 8, //*
        leftBracket = 9 //( 
    }

    public int typeRound = 0; // this should be an int
                   // 0 = comedian telling joke
                   // 1 = comedian done telling joke
                   // 2 = comedian and audience stare
                   // each round should be 5 or so seconds
    public float gameTimer;
    public float roundTimer;
    
    public GameObject[] AudiencesGameObject; //Collect
    Audience audience;

    GameObject comedianObject;
    Comedian comedian;
	Player player;

	GameObject playerObject;

	private void Start()
    {
        comedianObject = GameObject.Find("obj_comedian");
        comedian = comedianObject.GetComponent<Comedian>();
        gameTimer = 180.0f;
        roundTimer = 5.0f;

		playerObject = GameObject.Find("obj_player");
		player = playerObject.GetComponent<Player>();
	}

    private void Update()
    {
        if(gameTimer > 0.0f)
        {
            gameTimer -= Time.deltaTime;
            if (roundTimer > 0.0f)
            {
                roundTimer -= Time.deltaTime;
                Debug.Log("Round timer: " + roundTimer);
            }
            else if (roundTimer <= 0.0f)
            {
               switch (typeRound)
                {
                    case 0:
                        Debug.Log("joke over, laugh time");
                        typeRound = 1;
                        roundTimer = 5.0f;
                        break;
                    case 1:
                        Debug.Log("laugh over, joke time");
                        typeRound = 0;
                        roundTimer = 5.0f;
                        break;
                    case 2:
                        Debug.Log("the staring ends");
                        typeRound = 0;
                        roundTimer = 5.0f;
                        break;
                }
            }
        }
        else if(gameTimer <= 0.0f)
        {
            //add thing that makes game over happen
            //like change the scene to the score screen or something
            SceneManager.LoadScene("Screen Score");

        }
    }
	private void FixedUpdate()
	{
		//if (comedian.finalJokeScore )
        //{

       // }
	}

}
