using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterStats : MonoBehaviour {

	private int maxHealth = 10, currentHealth;
	public event System.Action<int, int> OnHealthUpdated;
	
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateHealth(){
		if(currentHealth > 0) {
			currentHealth--;
		} else {
			SceneManager.LoadScene("scene1");
		}
		OnHealthUpdated(maxHealth, currentHealth);
	}
}
