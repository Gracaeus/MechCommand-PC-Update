using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour {
    public GameObject shield;
    public shieldBehaviour shieldHealth;

    private bool shieldActivated = false;

    private void OnCollisionEnter(Collision collision)
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
    }
}
