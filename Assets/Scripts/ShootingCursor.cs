using UnityEngine;
using System.Collections;

public class ShootingCursor : MonoBehaviour {

	public Texture2D cursorTexture;

	void OnMouseEnter () {
		Vector2 hotspot = new Vector2(cursorTexture.width/2, cursorTexture.height/2);
		Cursor.SetCursor(cursorTexture, hotspot, CursorMode.Auto);
	}

	void OnMouseExit () {
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
	}
	
}
