using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthIndicate : MonoBehaviour {
	private int Health;
	Text t;
	// Use this for initialization
	void Start () {
		t=GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		Health = (int) GameObject.FindObjectOfType<Player>().health;
		t.text = "H:"+Health.ToString();
	}
}
