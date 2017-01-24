using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BlueScore : MonoBehaviour {

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
		if (other.gameObject.CompareTag ( "Cube2"))
		{
			Life = Life - 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "BlueLife: " + Life.ToString ();
		if (Life <= 0)
		{
			winText.text = "Red Wins!";
			Destroy (gameObject);
		}
	}
}