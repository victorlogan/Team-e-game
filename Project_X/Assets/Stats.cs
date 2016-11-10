﻿using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {
    [System.Serializable]
    public class PlayerStats{
        public int Health = 100;
    }

    public PlayerStats playerStats = new PlayerStats();

    public int fallBoundary = -20;

    void Update(){
        if (transform.position.y <= fallBoundary)
            DamagePlayer(999);
    }

    public void DamagePlayer(int damage){
        playerStats.Health -= damage;
        if(playerStats.Health <= 0){
            GameMaster.KillPlayer(this);
        }
    }

}
