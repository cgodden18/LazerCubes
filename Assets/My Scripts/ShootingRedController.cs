using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRedController : MonoBehaviour
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
		if (Input.GetButton("RedJoyStick1Fire1") && Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;
				Fire ();
			}
		}
}