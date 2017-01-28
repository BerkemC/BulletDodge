using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public GameObject bulletToDown,bulletToLeft,bulletToRight,bulletToUp;
	private StartTrack checkStart;
	public static float speed = 6f;
	public float freq = 0.2f;




	// Use this for initialization
	void Start () {
		checkStart = GameObject.FindObjectOfType<StartTrack> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(checkStart.IsStarted) {
			float prob = Time.deltaTime * freq;
			if (Random.value < prob) {
				if (Application.loadedLevel == 2)
					Fire ();
				else if (Application.loadedLevel == 4)
					Fire_Level_1 ();
				else if (Application.loadedLevel == 6)
					Fire_Level_2 ();
				else if (Application.loadedLevel == 7)
					Fire ();
				else if (Application.loadedLevel == 8)
					Fire ();
			}


			//The Part For Possible Skills 
			if (Player.lessFreqEnemy){
				if (Application.loadedLevel == 8)
					freq = 0.35f;
			}

			else{
				if (Application.loadedLevel == 8)
					freq = 0.7f;
			}
		}
	}

	void Fire(){  //TODO Use quaternion to rotate bullets so that you will use only one bullet sprite and get rid of 3 more lines !.
		if(transform.position.y > 8.90f){
			GameObject fireBullet = Instantiate (bulletToDown,new Vector3(transform.position.x,transform.position.y,0f),Quaternion.identity) as GameObject;
			fireBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(0f,-speed); 
		}else if(transform.position.x < 1.51f){
			GameObject fireBullet = Instantiate (bulletToRight,new Vector3(transform.position.x,transform.position.y,0f),Quaternion.identity) as GameObject;
			fireBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(speed,0f); 
		}else if(transform.position.y < 1.28f){
			GameObject fireBullet = Instantiate (bulletToUp,new Vector3(transform.position.x,transform.position.y,0f),Quaternion.identity) as GameObject;
			fireBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(0f,speed);
		}else if(transform.position.x > 12.0f){
			GameObject fireBullet = Instantiate (bulletToLeft,new Vector3(transform.position.x,transform.position.y,0f),Quaternion.identity) as GameObject;
			fireBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed,0f); 
		}
		GetComponent<AudioSource>().Play();
	}
	
	void Fire_Level_1(){
		GameObject fireBullet = Instantiate (bulletToDown, new Vector3 (transform.position.x, transform.position.y, 0f), Quaternion.identity) as GameObject;
		fireBullet.GetComponent <Rigidbody2D>().velocity = new Vector2 (0f,-speed);
		GetComponent<AudioSource> ().Play ();
	}
	void Fire_Level_2(){
		if(transform.position.x < 3f){
			GameObject fireBullet = Instantiate (bulletToRight, new Vector3 (transform.position.x, transform.position.y, 0f), Quaternion.identity) as GameObject;
			fireBullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, 0f);
		}else if(transform.position.x > 12f){
			GameObject fireBullet = Instantiate (bulletToLeft, new Vector3 (transform.position.x, transform.position.y, 0f), Quaternion.identity) as GameObject;
			fireBullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, 0f);
		}
		GetComponent<AudioSource> ().Play ();
	}
}
