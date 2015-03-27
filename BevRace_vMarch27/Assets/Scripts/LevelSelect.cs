using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	public bool isQuit = false;
	public bool isConvention = false;
	public bool isStreet = false;
	public bool isBar = false;
	public bool isNext1 = false;
	public bool isBack1 = false;
	public bool isNext2 = false;
	public bool isNext3 = false;
	public bool isNext4 = false;
	public bool isLast = false;
	public bool isMain = false;

	
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
		}
		if(isConvention == true){
			//load level
			Application.LoadLevel("gamev21");
		}
		if (isStreet == true) {
			Application.LoadLevel ("level2");
		}
		if (isBar == true) {
			Application.LoadLevel("level3");
		}
		if (isBack1 == true) {
			Application.LoadLevel ("HowTo");
		}
		if (isNext1 == true) {
			Application.LoadLevel ("HowToDrinkMeter");
		}
		if (isNext2 == true) {
			Application.LoadLevel ("HowToSprintMeter");
		}
		if (isNext3 == true) {
			Application.LoadLevel ("HowToChaseMeter");
		}
		if (isNext4 == true) {
			Application.LoadLevel ("HowToSpillMeter");
		}
		if (isLast == true) {
			Application.LoadLevel ("HowToPause");
		}
		if (isMain == true) {
			Application.LoadLevel ("select_menu");
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit();
		}
	}
}
