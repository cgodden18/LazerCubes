using UnityEngine;
using System.Collections;

public class BulletDieBlue : MonoBehaviour
{
	public GameObject explosion;

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Cube")
		{
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
		Instantiate(explosion, other.transform.position,other.transform.rotation);
	}
}