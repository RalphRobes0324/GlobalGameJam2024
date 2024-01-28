using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
}
