﻿using UnityEngine;
using System.Collections;

public class SelectLevel : MonoBehaviour {

	void OnMouseEnter(){
		//change text color
		renderer.material.color = Color.yellow;
	}
	
	void OnMouseExit(){
		//change text color
		renderer.material.color = Color.white;
	}
	
	void OnMouseUp(){
		Application.LoadLevel ("LevelSelectionScreen");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit();
		}
	}
}