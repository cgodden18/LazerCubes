using UnityEngine;
using System.Collections;

public class BulletDieRed : MonoBehaviour
{
	public GameObject explosion;

	public Transform BoomSpawn;

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Cube2")
		{
			return;
		}
		//Destroy(other.gameObject);
		Destroy(gameObject);
		Instantiate(explosion, BoomSpawn.position,other.transform.rotation);
	}
}