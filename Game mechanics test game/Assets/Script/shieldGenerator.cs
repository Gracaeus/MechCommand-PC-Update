using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldGenerator : MonoBehaviour {
	//public GameObject shield;
	//public shieldBehaviour shieldHealth;

	public GameObject shieldPrefab;
	public Transform shieldSpawn;

	private bool shieldActivated = false;

	/*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("bullet"))
        {
            if (shieldActivated == false)
            {
                shieldActivated = true;

                //shieldGenerator 
            }
            else
            {
                GetComponent<Rigidbody>().isKinematic = false;
            }

        }
    }*/

	public void SpawnShield(float HP)
	{
        //shieldPrefab.SendMessage("SetHP", HP);
		GameObject Shield = Instantiate(shieldPrefab, shieldSpawn.position, shieldSpawn.rotation);
        Shield.SendMessage("SetHP", HP);
	}

}
