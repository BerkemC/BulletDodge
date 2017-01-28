using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject enemy;
	public void OnDrawGizmos(){
		Gizmos.DrawWireCube(transform.position,new Vector3(13.30f,10f,0f));
	}
	void spawnEnemiesUntilFull(){
			foreach(Transform child in transform){
				GameObject Enemy = Instantiate(enemy,new Vector3(child.transform.position.x,child.transform.position.y,0f),Quaternion.identity) as GameObject;
				Enemy.transform.parent = child;
			}
	}
	// Use this for initialization
	void Start () {
		spawnEnemiesUntilFull();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
