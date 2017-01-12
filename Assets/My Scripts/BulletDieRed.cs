using UnityEngine;
using System.Collections;

public class BulletDieRed : MonoBehaviour
{
	public GameObject explosion;

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Cube2")
		{
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
		Instantiate(explosion, other.transform.position,other.transform.rotation);
	}
}