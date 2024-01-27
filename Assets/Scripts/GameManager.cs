using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private Comedian getComedian;
    private string getJoke;
    private bool getStatusJokeMade;

    ///Joke score if message
    public enum JokeScore 
    {
        exclamtionPoint = 1, //! = 1
        atPoint = 2, //@ = 2
        hashTagPoint = 3, //# = 3
        dolloarPoint = 4, // $ = 4 
        precentPoint = 5, //% = 5
        powerPoint = 6, // ^ = 6
        andPoint  = 7, // & = 7
        starPoint = 8, // * = 8
        leftBracket = 9, // ( = 9
        rightBracket = 0, // ) = 0
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
