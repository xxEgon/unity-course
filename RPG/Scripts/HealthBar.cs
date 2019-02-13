using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	Transform cam; 
	GameObject healthCanvas; 
	public GameObject healthPrefab; 
	public Transform target;
	private Transform prefInstance; 
	private Image healthSlider; 
	

	// Use this for initialization
	void Start () {
		cam = Camera.main.transform;
		healthCanvas = GameObject.Find("HealthCanvas");
		prefInstance = Instantiate(healthPrefab, healthCanvas.transform).transform;
		healthSlider = prefInstance.GetChild(0).GetComponent<Image>();
		healthSlider.fillAmount = 0.0f;
		GetComponent<CharacterStats>().OnHealthUpdated += UpdateHealth;

	}
	
	// Update is called once per frame
	void Update () {
		prefInstance.position = target.position;
		prefInstance.forward = -cam.forward;
	}

	public void UpdateHealth(int max, int current)
	{       
		float percent =  ( (max-current) / (float)max);
		healthSlider.fillAmount = percent;
	}
}
