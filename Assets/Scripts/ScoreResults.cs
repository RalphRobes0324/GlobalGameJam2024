using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreResults : MonoBehaviour
{
    public Sprite goodResult;
    public Sprite badResult;
    GameObject ScoreManager;
    scoreManager scoreScript;
    public float scoreResults;
    void Start()
    {
        ScoreManager = GameObject.Find("scoreManager");
        scoreScript = ScoreManager.GetComponent<scoreManager>();
        scoreResults = scoreScript.finalScore;
        Destroy(ScoreManager);
        Image result = GetComponent<Image>();

        if (scoreResults > 0)
        {
            result.sprite = goodResult;
        }
        else
        {
            result.sprite = badResult;
        }
    }
}
