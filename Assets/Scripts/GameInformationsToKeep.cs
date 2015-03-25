using UnityEngine;
using System.Collections;

public class GameInformationsToKeep : MonoBehaviour {

	public bool firstRoundPlayed = true;
	public float timerPlayer1;
	public float timerPlayer2;

	void Awake () {

		DontDestroyOnLoad (this);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
