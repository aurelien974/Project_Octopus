using UnityEngine;
using System.Collections;

public class ShootNet : MonoBehaviour {

	public Transform netPrefab;

	public float shootingRate = 1f;

	private float shootCooldown;

	// Use this for initialization
	void Start () {

		shootCooldown = 0f;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (shootCooldown > 0) {

			shootCooldown -= Time.deltaTime;

		}

//		bool shoot = Input.GetButtonDown("Fire1");
//		shoot |= Input.GetButtonDown("Fire2");
//
//		if (shoot && shootCooldown <= 0f) {
//
//			ShootANet();
//
//		}

	}

	void ShootANet() {

		shootCooldown = shootingRate;

		Transform newNet = Instantiate(netPrefab) as Transform;

		Vector2 netPosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
		newNet.position = netPosition;

	}

	void OnMouseDown() {

		if (shootCooldown <= 0f) {

			ShootANet();

		}

	}
}
