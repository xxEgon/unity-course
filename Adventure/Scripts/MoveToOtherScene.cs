using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToOtherScene : MonoBehaviour {

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("FPSController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown() {
   		float distance = Vector3.Distance(player.transform.position,transform.position);
		if(distance < 5f) {
			Debug.Log("CLICK CHEST");
			Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
			//Scene sceneToLoad = SceneManager.GetSceneByName("scene2");
			SceneManager.LoadScene("scene2", LoadSceneMode.Single);
			//SceneManager.MoveGameObjectToScene(player.gameObject, SceneManager.GetSceneAt(1));
		}
	}
}
