using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireScriptTwo : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireTime = 0.1f;
    private bool isFiring = false;
    public GameObject mech;

    // Use this for initialization
    void Start()
    {

        //bulletSpawn = GetComponent<Transform>("PlayerTwoBulletSpawn");
    }
    public void Fire()
    {
        isFiring = true;
        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        Invoke("SetFiring", fireTime);
    }

    void SetFiring()
    {
        isFiring = false;
    }
}
