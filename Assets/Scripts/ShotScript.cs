using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {
	
	public bool isNetOnGround = false;

	private SpriteRenderer sprite;
	public int sortingOrder = 1;

	// Use this for initialization
	void Start () {
	
		sprite = GetComponent<SpriteRenderer>();

		if (sprite) {

			sprite.sortingOrder = sortingOrder;

		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if (isNetOnGround && sprite.sortingOrder != -1) {

			sprite.sortingOrder = -1;
			this.GetComponent<ShotScript>().enabled = false;

		}

	}
}
