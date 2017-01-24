using UnityEngine;
using System.Collections;

public class BulletDieBlue : MonoBehaviour
{
	public GameObject explosion;	

	public Transform BoomSpawn;

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Cube")
		{
			return;
		}
		//Destroy(other.gameObject);
		Destroy(gameObject);
		Instantiate(explosion, BoomSpawn.position,other.transform.rotation);
	}
}