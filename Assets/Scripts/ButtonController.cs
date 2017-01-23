using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

	public void StartGame() {
		Debug.Log("starting");
		LoadingScreenManager.LoadScene (1);
	}
	public void OpenOptionsMenu() {
		Debug.Log ("opening options menu");
	}
	public void Quit() {
		Debug.Log ("quitting");
		Application.Quit ();
	}

}
