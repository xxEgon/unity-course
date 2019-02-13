using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsSteering : MonoBehaviour {

	public float rotation, move;
	public bool Moving_forward;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
			transform.Rotate(0,3,0, Space.Self);
		if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
			transform.Rotate(0,-3,0, Space.Self);

		if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
			transform.Translate(Vector3.forward/5);
			Moving_forward = true;
		} else Moving_forward = false;

		if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
			transform.Translate(-Vector3.forward/5);
	}
}
