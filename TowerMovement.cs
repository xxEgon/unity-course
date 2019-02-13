using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMovement : MonoBehaviour {

	private float speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range(0.02f, 0.08f);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y > 2.5f) {
			speed = -speed;	
		}
		if(transform.position.y < -2.5f) {
			speed = -speed;	
		}
		transform.Translate(0,speed,0);
	}
}
