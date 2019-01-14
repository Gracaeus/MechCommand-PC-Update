using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBullet : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public GameObject napalmPrefab;
    public GameObject quadPrefab;
    public float fireTime = 0.1f;
    private bool isFiring = false;

	void Start()
	{

	}
    public void Fire(float damage)
    {
        isFiring = true;
       // bulletPrefab.SendMessage("SetDamage", damage);
        GameObject Bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        Bullet.SendMessage("SetDamage", damage);

        Invoke("SetFiring", fireTime);
    }
	
    public void NapalmShot(float damage)
    {
        isFiring = true;
        GameObject Bullet = Instantiate(napalmPrefab, bulletSpawn.position, bulletSpawn.rotation);
        Bullet.SendMessage("SetDamage", damage);
    }

    public void QuadShot (float damage)
    {
        GameObject Bullet = Instantiate(quadPrefab, bulletSpawn.position, bulletSpawn.rotation);
        Bullet.SendMessage("SetDamage", damage);
    }
    
    void SetFiring()
    {
        isFiring = false;
    }

}
