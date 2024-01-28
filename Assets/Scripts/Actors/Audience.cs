using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audience : MonoBehaviour
{
    private float scoreTheJoke;
    private bool statusComedian;
    public bool statusAudi;

    [Header("Control Humour Level")]
    public float humourLevel;

    private GameObject comedian;
    private Comedian comedianScript;
    
    // Start is called before the first frame update
    private void Start()
    {

        comedian = GameObject.Find("obj_Comedian");
        comedianScript = comedian.GetComponent<Comedian>();
        humourLevel = 1.5f;
        statusAudi = false;

    }

    // Update is called once per frame
    private void Update()
    {

        scoreTheJoke = comedianScript.jokeScore;
        statusComedian = comedianScript.doneMakingJoke;
        if(statusComedian && !statusAudi)
        {
            Debug.Log(scoreTheJoke);
            statusAudi = true; //Ready listen to next joke
            
        }

        
        
    }
}
