using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	private void OnTriggerEnter(Collider other)
	{      
		if (other.gameObject.name == "FPSController"){
			//Debug.Log("LIGHT!");
			Light myLight = GameObject.Find("HouseLight").GetComponent<Light>();
			myLight.intensity = 2;
		}		
	}
}
