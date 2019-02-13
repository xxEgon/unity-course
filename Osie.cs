using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osie : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawLine(transform.position, new Vector3(0, 10, 0));
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(transform.position, new Vector3(0, 0, 10));
		Gizmos.color = Color.red;
		Gizmos.DrawLine(transform.position, new Vector3(10, 0, 0));
	}
}
