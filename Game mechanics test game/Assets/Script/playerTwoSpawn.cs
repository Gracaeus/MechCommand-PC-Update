using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTwoSpawn : MonoBehaviour
{

	public GameObject Enemy;
	public Transform enemySpawn;
	// Use this for initialization
	void Start()
	{
		spawnEnemy();
	}
	private void spawnEnemy()
	{
		Instantiate(Enemy, enemySpawn.position, enemySpawn.rotation); //as GameObject;
	}


}
