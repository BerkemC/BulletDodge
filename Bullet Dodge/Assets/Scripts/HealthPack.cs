using UnityEngine;
using System.Collections;

public class HealthPack : MonoBehaviour {
	public float freq = 0.2f,Xmin,Xmax,Ymin,Ymax;
	public GameObject pack;
	private StartTrack IsStart;
	// Use this for initialization
	void Start () {
		if(Application.loadedLevel == 4){
			Xmin = 0.5f;
			Xmax = 13f;
			Ymin = 0.5f;
			Ymax = 6f;
		}
		else {
			Xmin = 3f;
			Xmax = 11f;
			Ymin = 1.5f;
			Ymax = 8.5f;
				
		}
		IsStart = GameObject.FindObjectOfType<StartTrack> ();

	}
	
	// Update is called once per frame
	void Update () {
		float probability = Time.deltaTime * freq;
		if (Random.value < probability && IsStart.IsStarted == true)
			SpawnHealthPack ();
	}
	void SpawnHealthPack(){
		GameObject health = Instantiate (pack,new Vector3(Random.Range(Xmin,Xmax),Random.Range(Ymin,Ymax),0f),Quaternion.identity) as GameObject;
	}
}
