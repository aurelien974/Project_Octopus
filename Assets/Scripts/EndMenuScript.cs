using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndMenuScript : MonoBehaviour {

	public Text playerTimerText;
	public Text playerFirstRoundTimerText;
	public Text whoWinsText;

	private string winnerName;

	// Use this for initialization
	public void showTimersAndWinnerOnPanel (float timerPlayer) {
	
//		playerTimerText = GetComponent<Text> ();

		playerTimerText.text = "<b>Player 1</b> stayed alive for <b>" + timerPlayer.ToString ("0.00") + "</b> seconds";

		GameObject gameInformations = GameObject.Find ("GameInformations");
		GameInformationsToKeep gameInformationsScript = gameInformations.GetComponent<GameInformationsToKeep> ();

		playerFirstRoundTimerText.text = "<b>Player 2</b> stayed alive for <b>" + gameInformationsScript.timerPlayer2.ToString ("0.00") + "</b> seconds";

		if (gameInformationsScript.timerPlayer1 > gameInformationsScript.timerPlayer2) {

			winnerName = "Player 1";

		} else if (gameInformationsScript.timerPlayer1 < gameInformationsScript.timerPlayer2) {

			winnerName = "Player 2";

		} else {

			winnerName = "No one";

		}

		whoWinsText.text = "<b>" + winnerName + " wins !</b>";

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void backToMenu () {

		Application.LoadLevel ("mainMenu");

	}
}
