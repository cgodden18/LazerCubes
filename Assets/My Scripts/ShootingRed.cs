using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRed : MonoBehaviour 
{

	public GameObject bulletPrefab;

	public Transform bulletSpawn; 

	public float fireRate;

	private float nextFire;

	public float ShotSpeed;

	public float BulletLife;

	void Start () 
	{
		
	}

	void Fire ()
	{
		var bullet = (GameObject)Instantiate (bulletPrefab,bulletSpawn.position,bulletSpawn.rotation);

		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * ShotSpeed;
	
		Destroy(bullet, BulletLife);
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.RightShift) && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Fire ();
		}
	}
}