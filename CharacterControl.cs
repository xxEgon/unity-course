using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class CharacterControl:MonoBehaviour {



	private GameObject cam; 
	private float moveSpeed = 5f; 
	private float turnSpeed = 1f; 
	private float cameraRotX; 
 	private Vector3 move; 
	private CharacterController characterController; 

	// Use this for initialization
	void Start () {
		characterController = transform.GetComponent < CharacterController > (); 
		cam = GameObject.Find("Main Camera"); 
	}
	
	// Update is called once per frame
	void Update () {
		//rotacja postaci
		transform.Rotate(0, Input.GetAxis("Mouse X") * turnSpeed, 0); 

		//rotacja kamery
		cameraRotX = -Input.GetAxis("Mouse Y"); 
		cameraRotX = Mathf.Clamp(cameraRotX, -45f, 45f); // clamp ogranicza zmienną aby nie wyszła poza zakres
		cam.transform.Rotate(cameraRotX, 0, 0); 

		//WASD
		float deltaX = Input.GetAxis("Horizontal"); 
		float deltaZ = Input.GetAxis("Vertical"); 
		//
		move = new Vector3(deltaX, 0, deltaZ); 
		move = transform.TransformDirection(move); 
		
		//
		characterController.SimpleMove(move * moveSpeed ); 

	}
}
