using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Power : MonoBehaviour {
	public static int power=0;
	private Text t;
	// Use this for initialization
	void Start () {
		t = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (power > 70)
			t.color = Color.red;
		if (power > 100)
			t.color = Color.blue;
		if(power < 70)
			t.color = Color.white;
		t.text ="F:"+power;
	}
}
