using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healingBehaviour : MonoBehaviour {


    public float destroyTime = 1f;

   
    void Start()
    {
        Invoke("Die", destroyTime);
    }
    void Die()
    {
        Destroy(gameObject);
    }
}

