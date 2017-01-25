using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBlueController : MonoBehaviour {


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
		if (Input.GetButtonDown("JoyStick2Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Fire ();
		}
	}
}