using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour {

	private GameObject player;
	private float smooth = 50.0f;
	private bool openGate, closeGate, gateOpened;
	private GameObject rotationPoint;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("FPSController");
		openGate = false;
		closeGate = false;
		rotationPoint = new GameObject();
		rotationPoint.transform.position = transform.position;
		rotationPoint.transform.parent = transform;
		rotationPoint.transform.localPosition = new Vector3(-0.342f, 0  ,0);
		gateOpened = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(openGate) { 
			//Debug.Log("OPEN");
			transform.RotateAround(rotationPoint.transform.position, Vector3.up, smooth*Time.deltaTime);
		}
		if(closeGate) { 
			//Debug.Log("OPEN");
			transform.RotateAround(rotationPoint.transform.position, Vector3.down, smooth*Time.deltaTime);
		}
	}

	private void OnMouseDown() {
   		float distance = Vector3.Distance(player.transform.position,transform.position);
		if(distance < 5f) {
			//Debug.Log("CLICK");
			if(gateOpened) {
				closeGate = true;
				StartCoroutine(CloseAfterTime(1.7f));
			}
			else {
				openGate = true;
				StartCoroutine(OpenAfterTime(1.7f));
			}
			gateOpened = !gateOpened;
				
		}
	}
	IEnumerator OpenAfterTime (float time) {
		yield return new WaitForSeconds(time);
		openGate = false;
	}
	IEnumerator CloseAfterTime (float time) {
		yield return new WaitForSeconds(time);
		closeGate = false;
	}
}
