using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSheild : MonoBehaviour 
{
	public GameObject Sheild;

	public float SheildAmount;

	public Transform SheildSpawn;

	void Start ()
	{
		SheildAmount = 10;
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Q) && SheildAmount > 0)
			{
				SheildAmount -= 1;
				UseSheild ();
			}
		return;
	}

	void UseSheild ()
	{
		Instantiate (Sheild,SheildSpawn.position,SheildSpawn.rotation);
	}

}