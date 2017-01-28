using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float damage;
	// Use this for initialization
	void Start () {
		damage = Random.Range(50f,70f);
	}
}
