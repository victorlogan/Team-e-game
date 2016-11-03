﻿using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {
	//creates empty level manager of type levelmanager
	public LevelManager levelManager;


	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//detects when a player enters a trigger zone
	void OnTriggerEnter2D(Collider2D other) {
		if (other.name == "Player") {
			levelManager.RespawnPlayer();
		}
	}

}
