using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSADMove : MonoBehaviour {

	private float speed = 0.1f;
	private float speed2 = 0.8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float deltaX = Input.GetAxis("Horizontal") * speed; // wirtualne klawisze AD
		float deltaZ = Input.GetAxis("Vertical") * speed; // wirtualne klawisze WS

		// if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		// 	transform.Rotate(0,3,0, Space.Self);
		// if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		// 	transform.Rotate(0,-3,0, Space.Self);

		if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
			transform.Translate(deltaX, 0, deltaZ);
			//transform.Translate(deltaX * Time.deltaTime, 0, deltaZ * Time.deltaTime);;
			//transform.Translate(-Vector3.forward/5);
		if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
			transform.Translate(deltaX, 0, deltaZ);
			//transform.Translate(deltaX * Time.deltaTime, 0, deltaZ * Time.deltaTime);;
			//transform.Translate(Vector3.forward/5);

		transform.Rotate(0, Input.GetAxis("Mouse X") * speed2, 0);
	}
}
