using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour {

	float rotateZ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		//Debug.Log(( Input.mousePosition.x - (Screen.width/2)) / 30 );

		if(Input.mousePosition.x < Screen.width && Input.mousePosition.x > 0)		
			rotateZ = ( Input.mousePosition.x - (Screen.width/2)) / 30 ;
	
		transform.Rotate(0, 0, rotateZ, Space.Self);
	}
}
