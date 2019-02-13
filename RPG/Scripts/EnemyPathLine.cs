using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathLine : MonoBehaviour {

	float startZ, distance, speed, translateZ;
	Vector3 startPoint;
	// Use this for initialization
	void Start () {
		startZ = transform.position.z;
		//startY = transform.position.y;
		distance = 15f;
		speed = 0.05f;
		translateZ = 0;
		startPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(Vector3.Distance(startPoint, transform.position));
		// if(System.Math.Abs(transform.position.z - startZ) > distance) {
		// 	translateZ = speed;
		// }
		// if(System.Math.Abs(transform.position.z - startZ) <= 0) {
		// 	translateZ = -speed;
		// }
		// transform.Translate(0, 0, translateZ, Space.World);

		if(Vector3.Distance(startPoint, transform.position) > distance) {
			translateZ = -speed;
		}
		if(Vector3.Distance(startPoint, transform.position) <= 0.1) {
			translateZ = speed;
		}
		transform.Translate(0, 0, translateZ, Space.World);
	}
}
