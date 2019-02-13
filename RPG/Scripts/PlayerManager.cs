using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(NavMeshAgent))]

public class PlayerManager : MonoBehaviour {
	private bool follow;
	private float distance, minDistance = 2;
	private NavMeshAgent agent;
	private Camera cam;
	private Transform enemyToFollow;
	private PlayerAnimationManager animationManager;
	private SkinnedMeshRenderer[] meshes;
	private GameObject[] enemies;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		cam = Camera.main;
		follow = false;
		animationManager = transform.Find("model").GetComponent<PlayerAnimationManager>();
		meshes = gameObject.GetComponentsInChildren<SkinnedMeshRenderer>();
		for(int i= 0; i< meshes.Length; i++) {
			if(meshes[i].name != "Paladin_J_Nordstrom")
				meshes[i].enabled = false;
		}
		enemies = GameObject.FindGameObjectsWithTag("enemy");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1)){
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				if(hit.transform.tag == "enemy") {
					enemyToFollow = hit.transform;
					follow = true;
				}
			}
		}
		if(follow) {
			agent.SetDestination(enemyToFollow.position);
			agent.stoppingDistance = 2f;
			animationManager.walkRun(agent);
		}
		for(int i = 0; i< enemies.Length; i++){
			distance = Vector3.Distance(transform.position, enemies[i].transform.position);
			if(distance < minDistance) {
				Vector3 direction = (transform.position - enemies[i].transform.position).normalized;
				Quaternion rotateToTarget = Quaternion.LookRotation(new Vector3(-direction.x, 0, -direction.z));
				transform.rotation = rotateToTarget;
				if (Input.GetMouseButtonDown(0)){
					Ray ray = cam.ScreenPointToRay(Input.mousePosition);
					RaycastHit hit;
					if (Physics.Raycast(ray, out hit) && hit.transform == enemies[i].transform)
					{
						animationManager.attack();
						enemies[i].GetComponent<CharacterStats>().UpdateHealth();		
					}
				}
			}
		}
		if (Input.GetMouseButtonDown(0)){
			if (EventSystem.current.IsPointerOverGameObject())
				return;
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				if(hit.transform.tag == "walkable") {
					follow = false;
					agent.SetDestination(hit.point);
					agent.stoppingDistance = 0.5f;
					animationManager.walkRun(agent);
				}
			}
		}
	}

	public void ShowPlayerMesh(string name, bool enabled)
	{
		int index = GetMeshIndex(name);
		meshes[index].enabled = enabled;
	}

	public void ShowAllPlayerMeshes(bool enabled)
	{
		for(int i=0 ;i< meshes.Length; i++){
			if(meshes[i].name != "Paladin_J_Nordstrom"){
				meshes[i].enabled = enabled;
			}
		}      
	}

	int GetMeshIndex(string name)
	{
		for(int i= 0; i< meshes.Length; i++){
			if(meshes[i].name == name)
				return i;
		}      
		Debug.Log("Nie znaleziono mesha o tej nazwie");
		return -1;
	}
}
