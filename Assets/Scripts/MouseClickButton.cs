using UnityEngine;
using System.Collections;

public class MouseClickButton : MonoBehaviour {

	public Texture2D normalText;
	public Texture2D hoverText;


	void OnMouseEnter() {
		guiTexture.texture = hoverText; 
	}

}
