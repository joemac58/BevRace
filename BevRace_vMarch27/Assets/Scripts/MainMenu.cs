﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			Application.LoadLevel("select_menu");
		}
	}
}
