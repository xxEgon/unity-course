using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStopSpace : MonoBehaviour {

	public bool rotationOn = false;

	// Use this for initialization
	void Start () {
				
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			Debug.Log("KLIK");
			rotationOn = !rotationOn;
		}
		if(rotationOn)
			transform.Rotate(0, 0, 3f, Space.Self);
	}
}
