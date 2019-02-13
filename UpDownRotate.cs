using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownRotate : MonoBehaviour {

	public float rotateZ = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
			rotateZ += 0.1f;
		if(Input.GetKey(KeyCode.DownArrow) && rotateZ > 0f)
			rotateZ -= 0.1f;
			
		transform.Rotate(0, 0, rotateZ, Space.Self);
	}
}
