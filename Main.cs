using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	private Player player;
	private GameObject cube;

	// Use this for initialization
	void Start () {
		cube = GameObject.Find("ej");
		player = cube.GetComponent<Player>();
		player.GetInfo();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
