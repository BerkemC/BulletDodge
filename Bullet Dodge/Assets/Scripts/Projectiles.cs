using UnityEngine;
using System.Collections;

public class Projectiles : MonoBehaviour {
	void Update () {
		foreach(GameObject projectile in GameObject.FindGameObjectsWithTag("Bullet")){
			projectile.transform.parent = gameObject.transform;
		}
	}
}
