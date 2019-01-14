using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class healing : MonoBehaviour {

	public GameObject healingPrefab;
	public Transform healingSpawn;
	public float destroyTime = 1f;
    public GameObject playerPrefab;



   
	public void SpawnHealth(float amount)
	{
		Instantiate(healingPrefab, healingSpawn.position, healingSpawn.rotation);
        playerPrefab.SendMessage("Heal", amount);
	}

    void HealPlayer()
    {

    }
	
}
