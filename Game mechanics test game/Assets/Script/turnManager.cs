using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class turnManager : MonoBehaviour {
	private int turnNo;
	private bool choiceOneMade = false;
	private bool choiceTwoMade = false;
	private string moveOne;
	private string moveTwo;


    //public GameObject bulletPrefab;
    //public Transform bulletSpawnOne;
    //public Transform bulletSpawnTwo;
    //public float fireTime;

    public GameObject shieldPrefab;
	public Transform shieldSpawnOne;
	public Transform shieldSpawnTwo;

	public GameObject healPrefab;
	public Transform healSpawnOne;
	public Transform healSpawnTwo;

    public GameObject playerOneAsset;
    public GameObject playerTwoAsset;
    public fireBullet playerOneAttack;
    public fireBullet playerTwoAttack;

	// Use this for initialization
	void Start () {
		turnNo = 0;
		choiceOneMade = false;
		choiceTwoMade = false;

        playerOneAttack = playerOneAsset.GetComponent<fireBullet>();
        playerTwoAttack = playerTwoAsset.GetComponent<fireBullet>();
	}
	
	// Update is called once per frame
	void Update () {
        PlayerOne();
        PlayerTwo();
		if (choiceOneMade == true && choiceTwoMade == true)
		{
			Play(moveOne,moveTwo);
            UnityEngine.Debug.Log("Play Called");
		}
	}

    public void PlayerOne()
    {
        if (Input.GetButtonDown("Attack1"))
        {
            moveTwo = "attack";
            choiceOneMade = true;
            System.Console.WriteLine("Player One Attack");
        }
        if (Input.GetButtonDown("Shield1"))
        {
            moveTwo = "shield";
            choiceOneMade = true;
            System.Console.WriteLine("Player One Shield");
        }
        if (Input.GetButtonDown("Heal1"))
        {
            moveTwo = "heal";
            choiceOneMade = true;
            System.Console.WriteLine("Player One Heal");
        }
    }

	private void PlayerTwo()
	{
        if (Input.GetButtonDown("Attack2"))
        {
            moveTwo = "attack";
            choiceTwoMade = true;
            System.Console.WriteLine("Player Two Attack");
        }
        if (Input.GetButtonDown("Shield2"))
        {
            moveTwo = "shield";
            choiceTwoMade = true;
            System.Console.WriteLine("Player Two Shield");
        }
        if (Input.GetButtonDown("Heal2"))
        {
            moveTwo = "heal";
            choiceTwoMade = true;
            System.Console.WriteLine("Player Two Heal");
        }
        
	}

	private void Play(string choice, string secondChoice)
	{
        EndTurn();
        //Player One move
        {
            switch (choice)
            {
                case "attack":
                    //playerOneAttack.Fire();
                    break;
                case "shield":
                    Instantiate(shieldPrefab, shieldSpawnOne.position, shieldSpawnOne.rotation);
                    break;
                case "heal":
                    Instantiate(healPrefab, healSpawnOne.position, healSpawnOne.rotation);
                    break;
            }
        }
        // Player Two move
        {
            switch (secondChoice)
            {
                case "attack":
                    //playerTwoAttack.Fire();
                    break;
                case "shield":
                    Instantiate(shieldPrefab, shieldSpawnTwo.position, shieldSpawnTwo.rotation);
                    break;
                case "heal":
                    Instantiate(healPrefab, healSpawnTwo.position, healSpawnTwo.rotation);
                    break;
            }
        }

		//EndTurn();
	}

	private void EndTurn()
	{
		choiceOneMade = false;
		choiceTwoMade = false;
        UnityEngine.Debug.Log("Being called");

	}
		
	}

