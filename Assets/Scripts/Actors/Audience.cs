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
        //When the joke is done
        if (!comedian.statusCo)
        {
            statusAudi = true; //Start Action for Audience member
        }

        if (statusAudi)
        {
            Debug.Log(comedian.finalJokeScore / audiHumourLevel);
            statusAudi = false;
        }
        else
        {
            Debug.Log("done reacting");
        }
  
    }
}
