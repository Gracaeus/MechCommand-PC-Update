using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class health : MonoBehaviour
{
	public float playerStartHealth = 10f;
	public float playerHealth;

    public Slider healthBar;
    public GameObject healthBarUI;

    public bool burnDamage;
    private int burnCount = 0 ;

	//public Rigidbody rb;
    //public turnManager postion;
    //public Transform mySpawn;
    
	// Use this for initialization
	void OnEnable()
	{
		playerHealth = playerStartHealth;
        gameObject.SetActive(true);
        burnDamage = false;
        //healthBar.value = playerHealth;
        //SetPosition();    
        //rb = GetComponent<Rigidbody>();
        //rb.isKinematic = true;
    }

    // Update is called once per frame
    void FixedUpdate()
	{
		
		//if (playerHealth <= 0)
		//{
		//	rb.isKinematic = false;
		//}
	}
	void Hit(float damage)
	{
		playerHealth -= damage;
        //SetHealthBar();
		if (playerHealth < 1)
		{
			//rb.isKinematic = false;
			gameObject.SetActive(false);
            Die();
            //GetComponent<Rigidbody>().isKinematic = false;
            //Invoke("Die", destroyTime);
		}
	}

    public void BurnDamage()
    {
        playerHealth -= 5;
        burnCount += 1;
        if (playerHealth < 1)
        {
            Die();
        }
        if (burnCount == 5)
        {
            burnDamage = false;
            burnCount = 0;
        }
    }

    void SetBurnOn()
    {
        burnDamage = true;
    }

    void Die()
    {
        Debug.Log("RIP");
        gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Heal( float health)
    {
        playerHealth += health;
    }

    //public void SetPosition()
    //{
    //	if(mySpawn.tag == "playerOneSpawn")
    //       {
    //           postion.playerOneAsset = gameObject;
    //       }
    //       if (mySpawn.tag == "playerTwoSpawn")
    //       {
    //           postion.playerTwoAsset = gameObject;
    //       }

    //   }

    void SetHealthBar()
    {
        healthBar.value = playerHealth;
    }
}
