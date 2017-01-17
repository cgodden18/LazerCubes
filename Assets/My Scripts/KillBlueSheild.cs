using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBlueSheild : MonoBehaviour {

	public float SheildLife;

	void Start ()
	{
		SheildLife = 5;
	}

	void Update () 
	{
		Destroy (gameObject, SheildLife);
	}
}
