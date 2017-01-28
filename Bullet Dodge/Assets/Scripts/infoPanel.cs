using UnityEngine;
using System.Collections;

public class infoPanel : MonoBehaviour {
	private StartTrack startComponent;
	// Use this for initialization
	void Start () {
		startComponent = GameObject.FindObjectOfType<StartTrack> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (startComponent.IsStarted)
			gameObject.SetActive (false);
	}
}
