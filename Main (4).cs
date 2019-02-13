using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	private List<GameObject> list = new List<GameObject>();

	// Use this for initialization
	void Start () {
		for(int i =0 ;i< 6; i++){
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = new Vector3(0, i*2 ,0);
			cube.AddComponent(typeof(MouseInteract));
			list.Add(cube);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
