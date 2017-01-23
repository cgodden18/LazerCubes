using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnStart : MonoBehaviour {

	public EventSystem eventSystem;
	public GameObject selectedObject;
	// select the main option at start

	void Start () {
		eventSystem.SetSelectedGameObject (selectedObject);
		Debug.Log (eventSystem.currentSelectedGameObject);
	}

	// if there is a deselection, reselect the default.
	void Update () {
		if (eventSystem.currentSelectedGameObject == null) {
			eventSystem.SetSelectedGameObject (selectedObject);
		}
	}
}
