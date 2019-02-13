using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2Sec : MonoBehaviour {

	public float rotateX = 0f, rotateY = 0f, rotateZ = 0f;

	// Use this for initialization
	void Start () {
		transform.LookAt(new Vector3(0, 0, 0));
		rotateX = 5.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Debug.Log(Time.timeSinceLevelLoad); 

		//Debug.Log(Time.timeSinceLevelLoad  ); 	

		if(Time.timeSinceLevelLoad % 2 == 0) {
			Debug.Log("OBROT : " + Time.timeSinceLevelLoad); 
			if(rotateX != 0f) {
				rotateX = 0f;
				rotateY = 5.0f;
			}
			else if(rotateY != 0f){
				rotateY = 0f;
				rotateZ = 5.0f;
			}
			else if(rotateZ != 0f){
				rotateZ = 0f;
				rotateX = 5.0f;
			}				
		}
		transform.Rotate(rotateX,rotateY, rotateZ, Space.Self);
	}
}
