using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCubes : MonoBehaviour {
	private GameObject kula;

	// Use this for initialization
	void Start () {
		 kula = GameObject.Find("Sphere");
	}
	
	// Update is called once per frame
	void Update () {
		float distance;
		foreach (Transform t in transform)
		{
			 distance = Mathf.Abs(Vector3.Distance(kula.transform.position,t.position));
			 if(distance < 2.5f)
				t.GetComponent<Renderer>().material.color = Color.red;
			else
				t.GetComponent<Renderer>().material.color = Color.yellow;
		}
	}
}
