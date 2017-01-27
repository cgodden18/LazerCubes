using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;



public class ShootingBlueController : MonoBehaviour {
	public int playerId = 1;

	private Player player;

	public GameObject bulletPrefab;

	public Transform bulletSpawn; 

	public float fireRate;

	private float nextFire;

	public float ShotSpeed;

	public float BulletLife;


	void Awake ()
	{
		player = ReInput.players.GetPlayer(playerId);
	}

	void Fire ()
	{
		var bullet = (GameObject)Instantiate (bulletPrefab,bulletSpawn.position,bulletSpawn.rotation);

		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * ShotSpeed;

		Destroy(bullet, BulletLife);
	}

	void Update ()
	{
		if (player.GetButton(0) && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Fire ();
		}
	}
}