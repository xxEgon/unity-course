using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	private List<GameObject> listTiles = new List<GameObject>();

	public GameObject[][] tabTiles = new GameObject[9][];
	
	// Use this for initialization
	void Start () {


		Material mat = Resources.Load("Wireframe") as Material;
		mat.color = Color.yellow;

		for(int i=0;i<9;i++) {	
			tabTiles[i] = new GameObject[9];
			for(int j=0;j<9;j++) {
				GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
				tile.transform.parent = transform;
				tile.transform.position = new Vector3(i-4,0,j-4);
				tile.GetComponent<Renderer>().material = mat;
				tile.tag = "tile";
				tabTiles[i][j] = tile;
				listTiles.Add(tile);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
