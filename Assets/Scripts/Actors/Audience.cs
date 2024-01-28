using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audience : GameManager
{
    //Get Comedian Script and its variables
    GameObject comedianObject;
    Comedian comedian;

    GameObject gameManagerObject;
    GameManager gameManager;

    //Main functions of Audience
    public bool statusAudi;
    public float audiHumourLevel;
    public string getLaughter = "Not Laughing";

	public Animator[] animator;

    private void Start()
    {
        gameManagerObject = GameObject.Find("Game Manager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
        comedianObject = GameObject.Find("obj_comedian");
        comedian = comedianObject.GetComponent<Comedian>();
        statusAudi = false; //Audi is ready
        audiHumourLevel = 1.5f;
        getLaughter = "";
    }
    private void Update()
    {   
        //allow calculation
        if (gameManager.typeRound == 1 && !statusAudi)
        {
            statusAudi = !statusAudi;
        }
        //find reaction to joke
        if(gameManager.typeRound == 1 && statusAudi )
        {
            if (comedian.finalJokeScore > 0.0f)
			{
				float judgeThejoke = comedian.finalJokeScore / audiHumourLevel; //get Avg
				getLaughter = checkLaugh(judgeThejoke);
			}
            statusAudi = false; //Stop reacting
        }
        
        if (gameManager.typeRound == 0 || gameManager.typeRound == 2)
        {
            getLaughter = "Not Laughing";
        }
    }
	private void FixedUpdate()
	{
		switch (gameManager.typeRound)
        {
            case 2:
                animator[0].SetBool("isStaring", true);
				animator[1].SetBool("isStaring", true);
				animator[2].SetBool("isStaring", true);
				animator[3].SetBool("isStaring", true);
				animator[4].SetBool("isStaring", true);
				animator[5].SetBool("isStaring", true);
				animator[6].SetBool("isStaring", true);
				animator[7].SetBool("isStaring", true);
				animator[8].SetBool("isStaring", true);
				break;
            default:
                animator[0].SetBool("isStaring", false);
				animator[1].SetBool("isStaring", false);
				animator[2].SetBool("isStaring", false);
				animator[3].SetBool("isStaring", false);
				animator[4].SetBool("isStaring", false);
				animator[5].SetBool("isStaring", false);
				animator[6].SetBool("isStaring", false);
				animator[7].SetBool("isStaring", false);
				animator[8].SetBool("isStaring", false);
				break;

		}
		switch (getLaughter)
        {
            case "Not Laughing":
                animator[0].SetBool("isLaughing", false);
				animator[1].SetBool("isLaughing", false);
				animator[2].SetBool("isLaughing", false);
				animator[3].SetBool("isLaughing", false);
				animator[4].SetBool("isLaughing", false);
				animator[5].SetBool("isLaughing", false);
				animator[6].SetBool("isLaughing", false);
				animator[7].SetBool("isLaughing", false);
				animator[8].SetBool("isLaughing", false);
				break;
			case "Laughing ish":
                int a = UnityEngine.Random.Range(0, animator.Length), b = UnityEngine.Random.Range(0, animator.Length), c = UnityEngine.Random.Range(0, animator.Length), d = UnityEngine.Random.Range(0, animator.Length), e = UnityEngine.Random.Range(0, animator.Length);
                animator[a].SetBool("isLaughing", true);
				animator[b].SetBool("isLaughing", true);
				animator[c].SetBool("isLaughing", true);
				animator[d].SetBool("isLaughing", true);
				animator[e].SetBool("isLaughing", true);
				break;
			case "Laughing":
				animator[0].SetBool("isLaughing", true);
				animator[1].SetBool("isLaughing", true);
				animator[2].SetBool("isLaughing", true);
				animator[3].SetBool("isLaughing", true);
				animator[4].SetBool("isLaughing", true);
				animator[5].SetBool("isLaughing", true);
				animator[6].SetBool("isLaughing", true);
				animator[7].SetBool("isLaughing", true);
				animator[8].SetBool("isLaughing", true);
				break;
		}
	}
	private string checkLaugh(float judgeThejoke)
    {
        if(judgeThejoke >= 0.0f && judgeThejoke < 15.0f)
        {
            return "Not Laughing";
        }
        else if(judgeThejoke > 15.0f &&  judgeThejoke < 30)
        {
            return "Laughing ish";
        }
        else
        {
            return "Laughing";
        }
        
    }
}
