using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audience : MonoBehaviour
{
    private int scoreTheJoke;
    private int humourLevel;

    GameObject comedian;
    Comedian comedianScript;
    
    // Start is called before the first frame update
    private void Start()
    {

        comedian = GameObject.Find("obj_Comedian");
        comedianScript = comedian.GetComponent<Comedian>();

    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(comedianScript.comedianMakeJoke);
    }
}
