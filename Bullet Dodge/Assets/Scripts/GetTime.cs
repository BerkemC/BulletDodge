using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetTime : MonoBehaviour {
	Text t;
	private TimeKeeper time;
	private LevelManager levelManager;

	private StartTrack checkStart;
	// Use this for initialization
	void Start () {
		time = GameObject.FindObjectOfType<TimeKeeper>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		t = GetComponent<Text>();
		checkStart = GameObject.FindObjectOfType<StartTrack> ();
	}
	
	// Update is called once per frame
	void Update () {
		t.text = "T:"+ time.timeLeft;
		if(checkStart.IsStarted) {
			time.timeLeft -= Time.deltaTime;
			if (time.timeLeft <= 0f) {
				levelManager.LoadNextLevel ();
			}
		}
	}
}
