using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find("Player");
		Vector3 v = player.transform.position;
		transform.position = new Vector3(v.x, v.y+5, v.z - 10);
		
		//transform.Translate(Vector3.back*5);	
		//transform.rotation = player.transform.rotation;
		//transform.Translate(Vector3.back/5);
	}
}
