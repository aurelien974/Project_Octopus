using UnityEngine;
using System.Collections;

public class OctopusMovement : MonoBehaviour {

	public float speed = 10;

	private Vector2 movement;
	
	private float slowed;

	void Update () {
	
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		slowed = GetComponent<OctopusShot>().slowed;
		movement = new Vector2 (inputX * speed / slowed, inputY * speed / slowed);

	}

	void FixedUpdate() {

		rigidbody2D.velocity = movement;

	}
}
