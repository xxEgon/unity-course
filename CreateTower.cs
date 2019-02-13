using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTower : MonoBehaviour {
	private List < GameObject > list = new List < GameObject > ();
	// Use this for initialization
	void Start () {
		Material mat = Resources.Load("Wireframe") as Material;
		mat.color = Color.yellow;

		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 4; j++) {
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.transform.position = new Vector3((i*6)-9, 2.5f, (j*6)-9);
				cube.GetComponent<Renderer>().material = mat;
				cube.transform.localScale += new Vector3(1, 4, 1);
				cube.AddComponent<TowerMovement>();
				//cube.AddComponent<Rigidbody>();
				//cube.AddComponent<Rigidbody>().mass = 0.1f;
				list.Add(cube);
			}		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
