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

		if(transform.position.z < -5.0f) {
			Debug.Log("1");
			translateZ = 0.1f; 
			rotateZ = -5.0f;
		}
			
			
		if(transform.position.z > 5.0f) {
			Debug.Log("2");
			translateZ = -0.1f;
			rotateZ = 5.0f;
		}
			
		transform.Translate(0, 0, translateZ, Space.World);
		transform.Rotate(rotateZ, 0, 0, Space.Self);
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name != "Plane"){
			Debug.Log(other.gameObject);
			//other.transform.GetComponent<Renderer>().enabled = false;
			//other.gameObject.SetActive(false);
			//Destroy(other.gameObject);
		}
	}

}
