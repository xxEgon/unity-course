﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetCameraAndLoadSecondLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//SceneManager.LoadScene("scene2", LoadSceneMode.Single); 
		transform.LookAt(new Vector3(0, 0, 0));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Time.timeSinceLevelLoad > 2) {
			SceneManager.LoadScene("scene2", LoadSceneMode.Single); 
		}
		//Debug.Log(Time.timeSinceLevelLoad);
		//Debug.Log("a"+Time.time);
	}
}
