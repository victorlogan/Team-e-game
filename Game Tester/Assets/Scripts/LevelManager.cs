using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	//whatever point we want the player to respawn
	public GameObject currentCheckpoint;
	//what the player is
	private PlayerController player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//handles when the player respawns
	public void RespawnPlayer() {
		Debug.Log("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
	}
}
