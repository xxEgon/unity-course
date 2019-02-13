using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotation : MonoBehaviour {
	private float translateZ, rotateZ;

	// Use this for initialization
	void Start () {
		translateZ = 0.1f;
		rotateZ = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(transform.position);

		if(transform.position.z < -10.0f) {
			Debug.Log("1");
			translateZ = 0.1f; 
			rotateZ = -5.0f;
		}
			
			
		if(transform.position.z > 10.0f) {
			Debug.Log("2");
			translateZ = -0.1f;
			rotateZ = 5.0f;
		}
			
		transform.Translate(0, 0, translateZ, Space.World);
		transform.Rotate(rotateZ, 0, 0, Space.Self);
	}

	private void OnTriggerEnter(Collider other)
	{       
		Debug.Log(other.gameObject);
		if (other.gameObject.name != "Plane") {
			GetComponent<Renderer>().material.color = Color.blue;
		}	
	}

	private void OnTriggerExit(Collider other)
	{
		Debug.Log(other.gameObject);
		if (other.gameObject.name != "Plane") {
			GetComponent<Renderer>().material.color = Color.yellow;
		}	
	}

}
