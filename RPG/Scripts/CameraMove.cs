using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	private Vector3 offset = new Vector3(-5f, -5f, 0); //położenie kamery wględem Playera
	private float cameraZoom = 2f; // startowy zoom kamery
	private float pitch = 1f; // nachylenie w osi x
	private float zoomSpeed = 2f; // szybkość przybliżania kamery do playera
	private float minZoom = 1f; // minimalny zoom kamery
	private float maxZoom = 10f; //maksymalny zoom kamery
	private float yawSpeed = 1.5f; // szybkość rozgladania klawiszami AD
	private float cameraYaw = 0f; // bieżąca wartość rozglądania wg osi Y
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		cameraZoom += Input.GetAxis("Mouse ScrollWheel") * -zoomSpeed; // warość skrola
		cameraZoom = Mathf.Clamp(cameraZoom, minZoom, maxZoom); // ograniczenie zakresu zooma
		cameraYaw += Input.GetAxis("Horizontal") * yawSpeed; // klawiatura
	}
	 
	void LateUpdate () {
		transform.position = player.transform.position - offset * cameraZoom;
		transform.LookAt(player.transform.position + Vector3.up * pitch);
		transform.RotateAround(player.transform.position, Vector3.up, cameraYaw);
	}
}
