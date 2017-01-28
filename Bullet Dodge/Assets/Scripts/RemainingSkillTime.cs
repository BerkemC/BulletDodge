using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RemainingSkillTime : MonoBehaviour {
	Text t;
	int timeRemaining;
	// Use this for initialization
	void Start () {
		t=GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining = (int)Player.TimeToReduce;
		if (Player.TimeToReduce > 0f)
			t.text = timeRemaining.ToString ();
		else
			t.text = "";
	}
}
