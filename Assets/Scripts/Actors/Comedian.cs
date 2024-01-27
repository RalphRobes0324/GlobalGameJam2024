using System;
using UnityEngine;

public class Comedian : MonoBehaviour
{
    public enum JokeScore
    {
        exclamtionPoint = 1, //! = 1
        atPoint = 2, //@ = 2
        hashTagPoint = 3, //# = 3
        dolloarPoint = 4, // $ = 4 
        precentPoint = 5, //% = 5
        powerPoint = 6, // ^ = 6
        andPoint = 7, // & = 7
        starPoint = 8, // * = 8
        leftBracket = 9, // ( = 9
        rightBracket = 0, // ) = 0

    }
    //Set up different type of joke
    private string[] comedianJokes = {
        "!", "@", "#", "$", "%", "^", "&",
        "*", "(", ")"
    };

   

    //Track of jokes being created
    private string comedianMakeJoke;
    private int lengthJoke;
    public bool doneMakingJoke;

    public int jokeScore;

    private int finalScore;

    private void Start()
    {
        lengthJoke = comedianJokes.Length; //get length
        doneMakingJoke = false; //start creation
        jokeScore = 0;
        
    }
    private void Update()
    {
        if (!doneMakingJoke) //checks joke is not made yet
        {
            comedianMakeJoke = GetJokeRandom(); //get Joke
            Debug.Log(comedianMakeJoke);
        }
        if(doneMakingJoke && jokeScore == 0)
        {
            jokeScore = GetScore(comedianMakeJoke);
            Debug.Log(jokeScore);
        }
        
    }

    private int GetScore(string comedianMakeJoke)
    {
        
        char[] checkPoints = comedianMakeJoke.ToCharArray();
        foreach(char c in checkPoints)
        {
            if(c == '!')
            {
                finalScore += (int)JokeScore.exclamtionPoint;
            }
            else if(c == '@')
            {
                finalScore += (int)JokeScore.atPoint;
            }
            else if( c == '#')
            {
                finalScore += (int)JokeScore.hashTagPoint;
            }
            else if(c == '$')
            {
                finalScore += (int)JokeScore.dolloarPoint;
            }
            else if(c == '%')
            {
                finalScore += (int)JokeScore.precentPoint;
            }
            else if(c == '^')
            {
                finalScore += (int)JokeScore.powerPoint;
            }
            else if(c == '&')
            {
                finalScore += (int)JokeScore.andPoint;
            }
            else if(c == '*')
            {
                finalScore += (int)JokeScore.starPoint;
            }
            else if(c == '(')
            {
                finalScore += (int)JokeScore.leftBracket;
            }
            else
            {
                finalScore += 0;
            }
        }
        return finalScore;
    }


    //Get Random jokes
    private string GetJokeRandom()
    {
        string joke;
        joke = comedianJokes[RandomNum()];
        joke += comedianJokes[RandomNum()];
        joke += comedianJokes[RandomNum()];
        joke += comedianJokes[RandomNum()];
        joke += comedianJokes[RandomNum()];
        joke += comedianJokes[RandomNum()];
        doneMakingJoke = true;
        return joke;
    }

    //Get Random position of index based on range
    private int RandomNum()
    {
        int pos = UnityEngine.Random.Range(0, lengthJoke);
        return pos;
    }
    
}
