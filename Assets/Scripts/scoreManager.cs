using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float finalScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
