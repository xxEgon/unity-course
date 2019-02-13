using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3(4f, 4f, 4f);
		transform.Rotate(0,0,90);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(1f,0,0);
	}

	private void OnTriggerEnter(Collider other)
	{       
		//Debug.Log(other.gameObject);
		if (other.gameObject.name == "FPSController"){
			//other.transform.GetComponent<Renderer>().enabled = false;
			transform.gameObject.SetActive(false);
			GameObject.Find("Sounds").GetComponent<SoundManager>().PlayRandomSound();
			GameObject.Find("Score").GetComponent<ScoreManager>().AddScore();
			//Destroy(transform.gameObject);
		}
	}
}
