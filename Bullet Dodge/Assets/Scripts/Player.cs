using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	//Property Variables
	public float health = 500f;

	//Calling Variables
	private LevelManager levelManager;
	private Enemy enemyStats;

	//Time Variables
	public static float TimeToReduce = 0f;

	//skill variables
	public static bool slowMotionTime = false;
	public static bool lessFreqEnemy = false;


	//Default Variables


	// Use this for initialization
	void Start () {
		enemyStats = GameObject.FindObjectOfType<Enemy> ();

		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
		float mousePosX=Input.mousePosition.x/Screen.width * 13.5f;
		float mousePosY=Input.mousePosition.y/Screen.height * 10;
		if(Application.loadedLevel == 2){
			position.x = Mathf.Clamp(mousePosX,2f,11f);
			position.y = Mathf.Clamp(mousePosY,2f,8f);
		}else if (Application.loadedLevel == 4){
			position.x = Mathf.Clamp (mousePosX, 0.5f, 13f);
			position.y = Mathf.Clamp (mousePosY, 0.5f, 6f);
		}else if (Application.loadedLevel == 6){
			position.x = Mathf.Clamp (mousePosX, 3f, 11f);
			position.y = Mathf.Clamp (mousePosY, 1.5f, 8.5f);
		}else if (Application.loadedLevel == 7 || Application.loadedLevel == 8){
			position.x = Mathf.Clamp (mousePosX, 2.5f, 11f);
			position.y = Mathf.Clamp (mousePosY, 2f, 8f);
		}
	
		transform.position = position;


		//Part for the skills !!--!!--!!--!!--!!
		if(Power.power >= 70 && Input.GetKeyDown(KeyCode.Q) && slowMotionTime == false && Application.loadedLevel > 4){
			TimeToReduce = 10f;
			slowMotionTime = true;
			Power.power -= 70;
			slowMotionTimeApply ();

		}
		if(Power.power >= 100 && Input.GetKeyDown(KeyCode.W) && lessFreqEnemy == false && Application.loadedLevel >7){
			TimeToReduce = 15f;
			lessFreqEnemy = true;
			Power.power -= 100;
			lessFreqEnemyApply ();
		}
		if (TimeToReduce > 0f)
			TimeToReduce -= Time.deltaTime;
		else{
			slowMotionTime = false;
			lessFreqEnemy = false;
			TurnToDefault ();
		}
	}

	//Trigger
	void  OnTriggerEnter2D (Collider2D col){
		if(col.gameObject.GetComponent<Bullet>()){
			float damageTaken = col.gameObject.GetComponent<Bullet>().damage;
			if ((health - damageTaken) <= 0f) {
				if (Application.loadedLevel == 2){
					levelManager.LoadNextLevel();
				}else levelManager.LoadLevel("Lose");
			}
			Destroy(col.gameObject);
			health -= damageTaken;
		}
		else if (col.gameObject.GetComponent<Pack>()){
			Destroy (col.gameObject);
			health += 100f;
		}

	}

		
	//Skill functions
	void slowMotionTimeApply(){
		Enemy.speed /= 2;
		GetComponent<ParticleSystem> ().startColor = Color.red;
		GetComponent<ParticleSystem> ().startLifetime = 0.25f;

	}
	void lessFreqEnemyApply(){
		GetComponent<ParticleSystem> ().startColor = Color.blue;
		GetComponent<ParticleSystem> ().startLifetime = 0.25f;
	}
	//Default 
	void TurnToDefault(){
		DefaultProjectileSpeed ();
		//DefaultFreqEnemy ();
		DefaultParticleSettings ();
	}
	//Default Functions 

	//Particle
	void DefaultParticleSettings(){
		GetComponent<ParticleSystem> ().startColor = Color.white;
		GetComponent<ParticleSystem> ().startLifetime = 0.1f;
	}

	//Projectile
	void DefaultProjectileSpeed(){
		Enemy.speed = 6.0f;
	}
}
