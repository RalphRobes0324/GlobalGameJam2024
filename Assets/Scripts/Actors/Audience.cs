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
    public string getLaughter;

    
    private void Start()
    {
        gameManagerObject = GameObject.Find("Game Manager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
        comedianObject = GameObject.Find("obj_Comedian");
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
        if(gameManager.typeRound == 1 && statusAudi && gameManager.roundTimer >= 2.9f)
        {
            float judgeThejoke = comedian.finalJokeScore / audiHumourLevel; //get Avg
            getLaughter = checkLaugh(judgeThejoke);
            statusAudi = false; //Stop reacting
        }
        if (gameManager.typeRound == 0 || gameManager.typeRound == 2)
        {
            getLaughter = "Not Laughing";
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
