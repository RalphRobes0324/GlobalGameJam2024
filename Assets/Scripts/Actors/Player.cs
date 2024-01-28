using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameManager
{
	public bool laughing = false;
	public bool embarrassed = false;
	GameObject gameManagerObject;
	GameManager gameManager;
	private void Start()
	{
		gameManagerObject = GameObject.Find("Game Manager");
		gameManager = gameManagerObject.GetComponent<GameManager>();
	}
	private void Update()
	{
		if (!embarrassed && gameManager.typeRound == 2) { embarrassed = !embarrassed; }
		else if (embarrassed && gameManager.typeRound == 0 || gameManager.typeRound == 1) { embarrassed = !embarrassed; }
		if (Input.GetKeyDown("space") && gameManager.typeRound == 0 || gameManager.typeRound == 1) {laughing = true;}
		else if (Input.GetKeyUp("space")) {laughing = false;}
	}
}
