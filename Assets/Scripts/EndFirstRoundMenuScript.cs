using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndFirstRoundMenuScript : MonoBehaviour {
	
	public Text playerTimerText;
	
	// Use this for initialization
	public void showTimerOnPanel (float timerPlayer) {
		
		//		playerTimerText = GetComponent<Text> ();

		playerTimerText.text = "<b>Player 2</b> stayed alive for <b>" + timerPlayer.ToString ("0.00") + "</b> seconds";
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void startRound2 () {
		
		Application.LoadLevel ("inGame1");
		
	}

}
