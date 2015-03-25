using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour {

	Text timerText;
	public float timeElapsed;

	// Use this for initialization
	void Start () {

		timerText = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		timeElapsed = Mathf.Round (Time.timeSinceLevelLoad * 100) / 100;
		timerText.text = timeElapsed.ToString ("0.00");

	}
}
