using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tagged : MonoBehaviour {

	private GameObject[] cubes;

	// Use this for initialization
	void Start () {
		cubes = GameObject.FindGameObjectsWithTag("xxx"); // zwraca tablicę
		Debug.Log("ilość cubes"+cubes.Length);
	}
	
	// Update is called once per frame
	void Update () {
		
		foreach(GameObject o in cubes) {
			o.GetComponent<Renderer>().material.color = Color.green;
		}
		
	}
}
