using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSounds : MonoBehaviour {

	// Use this for initialization

	public AudioClip hover;
	public AudioClip click;
	public AudioSource source;

	public void OnHover() {
		source.PlayOneShot (hover);
	}
	public void OnClick() {
		source.PlayOneShot (click);	
	}
}
