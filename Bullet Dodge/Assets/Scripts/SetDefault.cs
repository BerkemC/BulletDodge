using UnityEngine;
using System.Collections;

public class SetDefault : MonoBehaviour {

	void Awake(){
		if (Application.loadedLevel == 4)
			Score.score = 0;
		if (Application.loadedLevel == 0)
			Score.score = 0;
		GameObject.FindObjectOfType<Player> ().health = 500f;
		Power.power = 0;
	}
}
