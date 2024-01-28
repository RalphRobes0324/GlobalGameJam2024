using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameManager
{
	public bool laughing = false;
	GameObject gameManagerObject;
	GameManager gameManager;
	GameObject comedianObject;
	Comedian comedian;

	GameObject ScoreManager;
	scoreManager scoreScript;

	public float totalScore = 0.0f;
	public float currentJokeScore = 0.0f;
	public bool laughedAtJoke = false;

	public Animator animator;
	private void Start()
	{
		gameManagerObject = GameObject.Find("Game Manager");
		gameManager = gameManagerObject.GetComponent<GameManager>();
		comedianObject = GameObject.Find("obj_comedian");
		comedian = comedianObject.GetComponent<Comedian>();

		ScoreManager = GameObject.Find("scoreManager");
		scoreScript = ScoreManager.GetComponent<scoreManager>();

		animator = GetComponent<Animator>();
	}
	private void Update()
	{
		if (Input.GetKey(KeyCode.Space)) 
		{
			laughing = true;
			animator.SetBool("isLaughing", true);

			if (gameManager.typeRound == 1 && currentJokeScore >= 15.0f && !laughedAtJoke)
			{
				totalScore += currentJokeScore;
				scoreScript.finalScore = totalScore;
				currentJokeScore = 0.0f;
				laughedAtJoke = true;
			}
			else if (gameManager.typeRound == 1 && laughedAtJoke)
			{ }
			else
			{
				totalScore -= currentJokeScore;
				currentJokeScore = 0.0f;
				if (gameManager.typeRound != 2)
				{
					gameManager.typeRound = 2;
					gameManager.roundTimer = 3.0f;

				}
			}
		}
		else if (Input.GetKeyUp(KeyCode.Space)){
			laughing = false;
			animator.SetBool("isLaughing", false);
		}
	}
}
