using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool doneMakingJoke;
    public string comedianMakeJoke;
    public float getJokeLevel;
    public bool checkJokeDone;

    public Comedian comedian;
    // Start is called before the first frame update
    void Start()
    {
        getJokeLevel = 0.0f;
        checkJokeDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
