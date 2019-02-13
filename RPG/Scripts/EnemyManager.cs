using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour {

	private NavMeshAgent agent;
	private EnemyAnimationManager animationManager;
	private Vector3 destinationPoint;
	private bool once = false;
	
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		animationManager = GetComponent<EnemyAnimationManager>();
		destinationPoint = new Vector3(3, 3, -5);
		setNewDestination(destinationPoint);
	}

	private void setNewDestination (Vector3 v) {
		agent.SetDestination(destinationPoint);
		animationManager.walkRun(agent);
		agent.stoppingDistance = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (agent.remainingDistance == 0 && once == false){
			once = true;
			StartCoroutine(Idle());
		}
	}

	IEnumerator Idle()
    {
        yield return new WaitForSeconds(5);
		destinationPoint = new Vector3(Random.Range(-20, 20), transform.position.y, Random.Range(-20, 20));
		//Debug.Log(destinationPoint);
		setNewDestination(destinationPoint);
		once = false;
    }
}
