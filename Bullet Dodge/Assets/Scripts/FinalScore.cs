using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FinalScore : MonoBehaviour {
	private Text t;
	// Use this for initialization
	void Start () {
		t = GetComponent<Text>();
		t.text = Score.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
