using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class RedShieldController : MonoBehaviour
{

	public int playerId = 0;

	private Player player;

	public GameObject Sheild;

	public float SheildAmount;

	public Transform SheildSpawn;

	public float NextSheild;

	public float SheildRate;

	void Start ()
	{
		SheildAmount = 10;
	}

	void Awake ()
	{
		player = ReInput.players.GetPlayer(playerId);
	}

	void Update ()
	{
		if (player.GetButton(1) && SheildAmount > 0 && Time.time > NextSheild)
		{
			NextSheild = Time.time + SheildRate;
			SheildAmount -= 1;
			UseSheild ();
		}
		return;
	}

	void UseSheild ()
	{
		Instantiate (Sheild,SheildSpawn.position,SheildSpawn.rotation);
		//Instantiate (transform.parent = this.transform);
	}

}