using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySliderValue : MonoBehaviour {

	// Use this for initialization
	public Slider slider;

	private Text number;
	public void updateValue() {
		
		number.text = slider.value.ToString();
	}
	void Start () {
		number = GetComponent<Text> ();
		number.text = slider.value.ToString();
		slider.onValueChanged.AddListener (delegate {
			updateValue ();
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
