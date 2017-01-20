using UnityEngine;
using System.Collections;

public class BulletDieRed : MonoBehaviour
{
	public GameObject explosion;

	public AudioClip Hit;

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Cube2")
		{
			return;
		}
		Instantiate (Hit);
		Destroy(other.gameObject);
		Destroy(gameObject);
		Instantiate(explosion, other.transform.position,other.transform.rotation);
	}
}