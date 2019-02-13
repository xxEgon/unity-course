using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteract : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown() {
   		Destroy(this.gameObject); // usunięcie klikanego obiektu
	}

	private void OnMouseOver() {
		transform.GetComponent<Renderer>().material.color = Color.blue; // zmiana koloru materiału
	}

	private void OnMouseExit() {
		transform.GetComponent<Renderer>().material.color = Color.yellow;
	}

}
