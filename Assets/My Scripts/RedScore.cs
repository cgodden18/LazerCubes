using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RedScore : MonoBehaviour {

	public Text countText;
	public Text winText;

	private int Life;

	void Start ()
	{
		Life = 4;
		SetCountText ();
		winText.text = "";
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Cube"))
		{
			Life = Life - 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "RedLife: " + Life.ToString ();
		if (Life <= 0)
		{
			winText.text = "Blue Wins!";
			Destroy (gameObject);
		}
	}
}