using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillRedSheild : MonoBehaviour {

	public float SheildLife;


	void Start ()
	{
		SheildLife = 1.5f;
	}

	void Update () 
	{
		Destroy (gameObject, SheildLife);
	}
}
