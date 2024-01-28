using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audience : GameManager
{
    //Get Comedian Script and its variables
    GameObject comedianObject;
    Comedian comedian;

    //Main functions of Audience
    public bool statusAudi;
    public float audiHumourLevel;

    
    private void Start()
    {
        comedianObject = GameObject.Find("obj_Comedian");
        comedian = comedianObject.GetComponent<Comedian>();
        statusAudi = false; //Audi is ready
        audiHumourLevel = 1.5f;
    }
    private void Update()
    {
        //Check when joke is done
        if (!comedian.statusCo)
        {
            statusAudi = true;
        }
        //Start reaction to joke
        if(statusAudi)
        {
            float judgeThejoke = comedian.finalJokeScore / audiHumourLevel; //get Avg
            statusAudi = false; //Stop reacting
        }


  
    }
}
