using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour {

	private float translateX, rotateZ;

	// Use this for initialization
	void Start () {
		 translateX = -0.1f;
		 rotateZ = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -5.0f) {
			translateX = 0.1f; 
			rotateZ = -5.0f;
		}
			
			
		if(transform.position.x > 5.0f) {
			translateX = -0.1f;
			rotateZ = 5.0f;
		}
			
		transform.Translate(translateX, 0, 0, Space.World);
		transform.Rotate(0, 0, rotateZ, Space.Self);
	}
}
