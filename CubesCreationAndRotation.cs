using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesCreationAndRotation: MonoBehaviour {

	private List < GameObject > list = new List < GameObject > ();

	// Use this for initialization
	void Start() {
		Material mat = Resources.Load("Wireframe") as Material;
		mat.color = Color.yellow;

		for (int i = 0; i < 5; i++) {
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = new Vector3(0, i, 0);
			cube.GetComponent<Renderer>().material = mat;
			list.Add(cube);
		}

	}

	// Update is called once per frame
	void Update() {
		foreach (GameObject cube in list)
		{
			cube.transform.Rotate(0,5.0f,0);
		}
	}
}