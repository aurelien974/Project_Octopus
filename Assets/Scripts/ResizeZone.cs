using UnityEngine;
using System.Collections;

public class ResizeZone : MonoBehaviour {

	void Awake() {

		Vector2 newSize = new Vector2(GameObject.Find ("sand background").renderer.bounds.size.x, GameObject.Find ("sand background").renderer.bounds.size.y);
		GetComponent<BoxCollider2D>().size = newSize;

	}
	
}
