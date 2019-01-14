using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldBehaviour : MonoBehaviour {

    protected float shieldHP;
    private float baseShieldHP;

	public float destroyTime = 2f;
	Animator anime;

	void Start()
	{
		shieldHP = baseShieldHP;
		Invoke("Die", destroyTime);
	}
	void Die()
	{
		Destroy(gameObject);
	}


    public void takeDamage(float damage)
    {
        shieldHP -= damage;
        if (shieldHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            collision.SendMessage("HealthUpdate", baseShieldHP);
            
        }
    }
    void SetHP(float amount)
    {
        baseShieldHP = amount;
    }

}
