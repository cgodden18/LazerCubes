using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MovementScript : MonoBehaviour {

	public Slider healthBarSlider;  
	public Text gameOverText;  
	private bool isGameOver = false; 

	void Start(){
		gameOverText.enabled = false;
	}


	void Update () {
		
		if(!isGameOver)
			transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*10f, 0, 0); //get input
	}


	void OnTriggerStay(Collider other){
		
		if(other.gameObject.name=="Fire" && healthBarSlider.value>0){
			healthBarSlider.value -=.1f;  //reduce health
		}
		else{
			isGameOver = true;    //set game over to true
			gameOverText.enabled = true; //enable GameOver text
		}
	}
}