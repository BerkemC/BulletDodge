using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StartTrack : MonoBehaviour {
	public bool IsStarted = false;
	private Text t;
	// Use this for initialization
	void Start () {
		t = GetComponent<Text> ();
		GameObject panel = GameObject.FindGameObjectWithTag ("Panel");
		if (panel)
			t.transform.parent = panel.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			t.text = "";
			IsStarted = true;
		}
	}
}
