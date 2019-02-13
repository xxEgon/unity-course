using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	private int score = 0;	
	private Text points;

	public int GetScore(){
		return score;
	}
	public void AddScore(){
		score++;
		points.text = score+" points";
	}
	// Use this for initialization
	void Start () {
		points = GetComponentInChildren(typeof(Text)) as Text;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
