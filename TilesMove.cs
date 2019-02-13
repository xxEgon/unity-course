using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesMove : MonoBehaviour {

	private static GameObject player;
	private static ArrowsSteering playerScript;
	private static Main mainScript;
	private GameObject oneTile;
	private bool mf;
	private int mid;
	public GameObject[][] tabTiles = new GameObject[9][];

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		playerScript = player.GetComponent<ArrowsSteering>();
		oneTile = GameObject.FindGameObjectWithTag("tile");
		mainScript = FindObjectOfType<Main>();//oneTile.GetComponent<Main>();
		
		//for(int i=0;i<9;i++) {	
			//tabTiles[i] = new GameObject[9];
			//for(int j=0;j<9;j++) 
				tabTiles = mainScript.tabTiles;
		//}
		

		mid = 4;//Mathf.FloorToInt(tabTiles.Length / 2);
		Debug.Log("MID: " + mid);
	}

	float distanceVector (Vector3 v1, Vector3 v2) {
		return Mathf.Abs(Vector3.Distance(v1, v2));
	}
	
	// Update is called once per frame
	void Update () {   
		mf = playerScript.Moving_forward; 
		//Debug.Log(mf);

		if (distanceVector(tabTiles[mid][tabTiles[mid].Length - 1].transform.position, player.transform.position) > (tabTiles.Length / 2) + 0.75) {
			for (var i = 0; i < tabTiles[mid].Length; i++) {
				GameObject[] pom = tabTiles[tabTiles[i].Length - 1];
				tabTiles[tabTiles[i].Length - 1] = tabTiles[i];
				tabTiles[i] = tabTiles[tabTiles[i].Length - 1];			
				tabTiles[i][0].transform.Translate(new Vector3(0,0, tabTiles[i].Length));

				// tabTiles[i][0].translateZ(tabTiles.length * 50)
				// tabTiles[i].push(tabTiles[i].shift())
			}
		}

		if (distanceVector(tabTiles[mid][0].transform.position, player.transform.position) > (tabTiles.Length / 2) + 0.75)
		{
			for (var i = 0; i < tabTiles[mid].Length; i++) {

				tabTiles[i][0].transform.Translate(new Vector3(0,0, -1 * tabTiles[i].Length));
				GameObject[] pom = tabTiles[i];
				tabTiles[i] = tabTiles[tabTiles[i].Length - 1];
				tabTiles[tabTiles[i].Length - 1] = pom;

				// GameObject[] pom = tabTiles[i];
				// tabTiles[i] = tabTiles[tabTiles[i].Length - 1];
				// tabTiles[tabTiles[i].Length - 1] = pom;
				// tabTiles[i][0].transform.Translate(new Vector3(0,0,tabTiles[i].Length));

				// tabTiles[i].unshift(tabTiles[i].pop())
				// tabTiles[i][0].translateZ(-tabTiles.length * 50)
			}
		}	

		// if (distanceVector(tabTiles[0][mid].position, player.position) > (tabTiles.length / 2) * 50 + 5) {	
		// 	for (var i = 0; i < tabTiles[0].length; i++) {
		// 		//tabTiles[0][i].translateX(tabTiles.length * 50)
		// 	}
		// 	//tabTiles.push(tabTiles.shift())
		// }

		// if (distanceVector(tabTiles[mid][tabTiles[mid].length - 1].position, player.position) > (tabTiles.length / 2) * 50 + 5) {
		// 	//tabTiles.unshift(tabTiles.pop())
		// 	for (var i = 0; i < tabTiles[0].length; i++) {
		// 		//tabTiles[0][i].translateX(-tabTiles.length * 50)
		// 	}                       
		// }
	}
}
