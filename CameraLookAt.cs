using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(GameObject.Find("Samolot").transform.position);
		transform.LookAt(GameObject.Find("Samolot").transform.position);
	}
}
