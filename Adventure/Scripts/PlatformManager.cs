using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformManager : MonoBehaviour {

	private float translateX, rotateZ, speed;
	private bool playerOn, dead;

	// Use this for initialization
	void Start () {
		speed = 0.1f;
		translateX = -speed;
		playerOn = false;
		dead = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x > 65.0f) {
			translateX = -speed; 
		}	
		if(transform.position.x < 50.0f) {
			translateX = speed;
		}	
		transform.Translate(translateX, 0, 0, Space.Self);

		if(playerOn) {
			if(translateX > 0)
				GameObject.Find("FPSController").transform.Translate(0, 0, translateX, Space.Self);
			else
				GameObject.Find("FPSController").transform.Translate(0, 0, -translateX, Space.Self);
		}
		//Debug.Log(GameObject.Find("FPSController").transform.position.y);
		if(GameObject.Find("FPSController").transform.position.y < -5.0f && !dead) {
			dead = true;
			Debug.Log("GAME OVER");
			GameObject.Find("GameOver").GetComponent<GameOver>().enable();
			StartCoroutine( MakeTimeout() );
		}
	}

	private void OnTriggerEnter(Collider other)
	{      
		if (other.gameObject.name == "FPSController"){
			Debug.Log("PLAYER ON THE BOARD");
			playerOn = true;
		}		
	}
	private void OnTriggerExit(Collider other)
	{      
		if (other.gameObject.name == "FPSController"){
			playerOn = false;
		}		
	}

	public IEnumerator MakeTimeout(){        
    	yield return new WaitForSeconds(2);
		SceneManager.LoadScene("scene2", LoadSceneMode.Single); 
    	// to o ma się wykonać po 2 sekundach
	}

}
