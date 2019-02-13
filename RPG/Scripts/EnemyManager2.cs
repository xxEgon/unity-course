using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager2 : MonoBehaviour {

	private GameObject player;
	private bool attack;
	private float minDistance = 2;
	private EnemyAnimationManager animationManager;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		InvokeRepeating("AttackPlayer", 0, 1.0f);
		animationManager = transform.GetChild(0).GetComponent<EnemyAnimationManager>();
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(player.transform.position, transform.position);
		if(distance <  minDistance) {
			Vector3 direction = (transform.position - player.transform.position).normalized;
			Quaternion rotateToTarget = Quaternion.LookRotation(new Vector3(-direction.x, 0, -direction.z));
			transform.rotation = rotateToTarget;
			attack = true;
		}
		else {
			attack = false;
		}
	}

	void AttackPlayer(){
		if(attack){
			player.GetComponent<CharacterStats>().UpdateHealth();
			animationManager.attack();
		}		
	}
}
