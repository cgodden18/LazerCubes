using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () 
	{
		moveSpeed = 100f;

	}
	
	// Update is called once per frame
	void Update ()
	{
		//print ("yo Im a cube");

		//transform.Translate (30f*Time.deltaTime,0f,0f);

		//print (Input.GetAxis ("Horizontal"));

		transform.Translate (0f, 0f , moveSpeed*Input.GetAxis ("Vertical") * Time.deltaTime);

	}
}
