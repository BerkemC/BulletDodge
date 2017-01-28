using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel+1);
	}
	public void LoadSameLevel(){
		Application.LoadLevel(Application.loadedLevel-1);
	}
	public void Exit(){
		Application.Quit();
	}
}
