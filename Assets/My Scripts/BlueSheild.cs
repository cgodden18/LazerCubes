using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSheild : MonoBehaviour 
{
	public GameObject Sheild;

	private float SheildAmount;

	void Start ()
	{
		SheildAmount = 10;
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Q) && SheildAmount > 0);
			{
				SheildAmount -= 1;
				UseSheild ();
			}
	}

	void UseSheild ()
	{
				
	}

}