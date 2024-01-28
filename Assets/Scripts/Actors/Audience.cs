using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audience : GameManager
{
    GameObject comedianObject;
    Comedian comedian;

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
            Debug.Log(comedian.finalJokeScore);
            statusAudi = false;
        }


  
    }
}
