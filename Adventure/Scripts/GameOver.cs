using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	private Text mytext;
	private Font font;
	private Canvas canvas;

	// Use this for initialization
	void Start () {
		canvas = GameObject.Find("GameOver").GetComponent<Canvas>();

		mytext = GetComponentInChildren(typeof(Text)) as Text;
		font = Resources.Load("Fonts/BlackHanSans-Regular") as Font;

		mytext.font = font;
		//mytext.fontSize = 70;
		//mytext.color = Color.yellow;

	}

	public void setFontType(Font font) {
		mytext.font = font;
	}
	public void enable() {
		canvas.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
