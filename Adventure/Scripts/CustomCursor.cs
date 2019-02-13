using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour {

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("FPSController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseExit() {
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		//Debug.Log("Cursor OFF");
	}

	private void OnMouseEnter() {
		float distance = Vector3.Distance(player.transform.position,transform.position);
		if(distance < 5f) {
			Texture2D cursor = Resources.Load("cursor1") as Texture2D;
			Cursor.SetCursor(cursor, new Vector2(32, 32), CursorMode.ForceSoftware);
			Cursor.visible = true;
		}	
	}
}
