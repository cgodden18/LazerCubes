using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Selector_Controller : MonoBehaviour {

	// Use this for initialization
	public EventSystem eventSystem;


	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// check for a selected game object (there should always be one.)
		if (eventSystem.currentSelectedGameObject != null) {
			// get the position of it and translate to it.

		}
	}
}
