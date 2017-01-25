using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShieldController : MonoBehaviour {

	public GameObject Sheild;

	public float SheildAmount;

	public Transform SheildSpawn;

	public float NextSheild;

	public float SheildRate;

	void Start ()
	{
		SheildAmount = 10;
	}

	void Update ()
	{
		if (Input.GetButtonDown("JoyStick1Fire2") && SheildAmount > 0 && Time.time > NextSheild)
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