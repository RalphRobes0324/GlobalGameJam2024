using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    float finalScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        DontDestoryOnLoad(this.gameObject);
        if (SceneManager.GetActiveScene().name == "Screen Score")
        {
            Destory(this.gameObject);
        }
    }
}
