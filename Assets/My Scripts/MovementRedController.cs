using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRedController : MonoBehaviour {

	public float moveSpeed1;
	private Rigidbody rbody;

	// Use this for initialization
	void Start () 
	{
		rbody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update ()
	{
		float inputZ = Input.GetAxis ("JoyStick1Vertical");

		float inputX = Input.GetAxis ("JoyStick1Horizontal");

		float moveZ = inputZ * moveSpeed1 * Time.deltaTime;

		float moveX = inputX * moveSpeed1 * Time.deltaTime;

		rbody.AddForce (0f,0f,moveZ);

		rbody.AddForce (moveX, 0f, 0f);
	}		
}
