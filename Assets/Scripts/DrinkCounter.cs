using UnityEngine;
using System.Collections;

public class DrinkCounter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	float counter = 1000;
	float count;			//variable used to update the counter

	// Update is called once per frame
	void Update () {

		//If the player is drinking, then update the counter
		count = Input.GetAxis ("Vertical");
		if (count < 0) 
			counter-= 1;
		
		//Displays how much the player has left to drink
		if(counter > 0)
			guiText.text = "Drink:  " + counter;

		//Game Over Screen if nothing left to drink
		if (counter == 0) {
			guiText.text = "Congratulations you drank it all!";
			Time.timeScale = 0;
			}
	}
}
