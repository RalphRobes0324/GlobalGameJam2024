using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool RoundDone;
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




    // Start is called before the first frame update
    void Start()
    {
        RoundDone = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
