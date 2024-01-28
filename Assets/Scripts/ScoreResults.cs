using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreResults : MonoBehaviour
{
    public Sprite goodResult;
    public Sprite badResult;
    public int scoreResults = 50;
    void Start()
    {
        Image result = GetComponent<Image>();

        if (scoreResults >= 50)
        {
            result.sprite = goodResult;
        }
        else
        {
            result.sprite = badResult;
        }
    }
}
