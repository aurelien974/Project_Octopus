using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OctopusShot : MonoBehaviour {

	public float slowEffect = 2;
	public float slowed = 1;

	public Text timer;

	public Transform shootzone;

	public RectTransform canvasEndMenuPrefab;
	public RectTransform canvasEndGameMenuPrefab;

	void OnTriggerEnter2D(Collider2D otherCollider) {

		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
		
		if (shot != null) {
		
			if (!shot.isNetOnGround) {

				// Stop Timer
				timer.GetComponent<TimerUI>().enabled = false;

				// Make Net On Octopus
				//SpriteRenderer net = otherCollider.gameObject.GetComponent<SpriteRenderer>();
				//net.sortingOrder = -1;
				shot.enabled = false;


				// End round
				endGame (timer.GetComponent<TimerUI>().timeElapsed);


			} else {

				slowed = slowEffect;

			}

		}

	}

	void OnTriggerExit2D(Collider2D otherCollider) {

		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
		
		if (shot != null) {

			if (shot.isNetOnGround) {

				slowed = 1;

			}

		}

	}

	void endGame(float timerPlayer) {

		// Stop Octopus Movement
		rigidbody2D.velocity = new Vector2(0, 0);
		GetComponent<OctopusMovement> ().enabled = false;

		// Stop shooting
		shootzone.GetComponent<ShootNet> ().enabled = false;

		// Stop cursor
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);

		// Show menu
		GameObject gameInformations = GameObject.Find ("GameInformations");
		GameInformationsToKeep gameInformationsScript = gameInformations.GetComponent<GameInformationsToKeep> ();

		if (gameInformationsScript.firstRoundPlayed) {

			gameInformationsScript.firstRoundPlayed = false;
			gameInformationsScript.timerPlayer2 = timerPlayer;

			RectTransform canvasEndMenu = Instantiate (canvasEndMenuPrefab) as RectTransform;
			canvasEndMenu.GetComponent<EndFirstRoundMenuScript> ().showTimerOnPanel (timerPlayer);

		} else {

			gameInformationsScript.firstRoundPlayed = true;
			gameInformationsScript.timerPlayer1 = timerPlayer;

			RectTransform canvasEndGameMenu = Instantiate (canvasEndGameMenuPrefab) as RectTransform;
			canvasEndGameMenu.GetComponent<EndMenuScript> ().showTimersAndWinnerOnPanel (timerPlayer);

		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
