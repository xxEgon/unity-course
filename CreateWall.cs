using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour {

	private List < GameObject > list = new List < GameObject > ();

	// Use this for initialization
	void Start () {
		Material mat = Resources.Load("Wireframe") as Material;
		mat.color = Color.yellow;

		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.transform.position = new Vector3(i-2, j+5, 0);
				cube.GetComponent<Renderer>().material = mat;
				//cube.AddComponent<Rigidbody>();
				cube.AddComponent<Rigidbody>().mass = 0.1f;
				list.Add(cube);
			}		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
