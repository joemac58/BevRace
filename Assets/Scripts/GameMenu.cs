using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {

	public bool isQuit = false;

	void OnMouseEnter(){
		//change text color
		renderer.material.color = Color.yellow;
	}

	void OnMouseExit(){
		//change text color
		renderer.material.color = Color.white;
	}

	void OnMouseUp(){
		//is this quit
		if (isQuit == true) {
			//quit the game
			Application.Quit ();
			} else {
			//load level
			Application.LoadLevel("gamev3");
			}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit();
		}
	}
}
