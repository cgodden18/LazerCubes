using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevel : MonoBehaviour {

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Alpha0))
			{
			Application.LoadLevel (0);
			}
	}
}
