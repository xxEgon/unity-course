using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathCircle : MonoBehaviour {

	private float radius, translateX, translateZ, speed;
	private Vector3 v, point; 
	// Use this for iitialization
	void Start () {
		radius = 4f;
		translateX = 0;
		translateZ = 0;
		speed = 40f;
		point = transform.position;
	 	transform.Translate(radius, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		//Quaternion q = transform.rotation;
		transform.RotateAround(point, Vector3.up, speed *Time.deltaTime);
		//transform.rotation = q;
	}
}
