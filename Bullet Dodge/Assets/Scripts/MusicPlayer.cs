using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	public AudioClip[] clipList;

	private AudioSource music;
	// Use this for initialization
	void Start () {
		if(instance) Destroy(gameObject);
		else{
		 	instance=this;
			GameObject.DontDestroyOnLoad(gameObject);
			music = GetComponent<AudioSource>();
			music.clip = clipList[0];
			music.loop = true;
			music.Play();
		}
	
	}

	void OnLevelWasLoaded(int lvl){
		if(lvl == 2) {
			music.Stop();
			music.clip = clipList[1];
			music.loop = true;
			music.Play();
		}

	}
}
