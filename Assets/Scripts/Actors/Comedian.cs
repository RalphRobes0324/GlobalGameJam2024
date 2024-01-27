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
    public string comedianMakeJoke;
    private int lengthJoke;
    public bool doneMakingJoke;
    public float jokeScore;
    private float finalScore;

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
            
        }
        if(doneMakingJoke && jokeScore == 0) //Checks joke is done
        {
            jokeScore = GetScore(comedianMakeJoke);
           
        }
        
    }

    private float GetScore(string comedianMakeJoke)
    {
        
        char[] checkPoints = comedianMakeJoke.ToCharArray();
        foreach(char c in checkPoints)
        {
            if(c == '!')
            {
                finalScore += (float)JokeScore.exclamtionPoint;
            }
            else if(c == '@')
            {
                finalScore += (float)JokeScore.atPoint;
            }
            else if( c == '#')
            {
                finalScore += (float)JokeScore.hashTagPoint;
            }
            else if(c == '$')
            {
                finalScore += (float)JokeScore.dolloarPoint;
            }
            else if(c == '%')
            {
                finalScore += (float)JokeScore.precentPoint;
            }
            else if(c == '^')
            {
                finalScore += (float)JokeScore.powerPoint;
            }
            else if(c == '&')
            {
                finalScore += (float)JokeScore.andPoint;
            }
            else if(c == '*')
            {
                finalScore += (float)JokeScore.starPoint;
            }
            else if(c == '(')
            {
                finalScore += (float)JokeScore.leftBracket;
            }
            else
            {
                finalScore += 0.0f;
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
