using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimationManager : MonoBehaviour {

	private Animator animator;
	private bool setRunning = false;
	float move = 0;
	private bool setJumping = false, startWalkRun = false;
	int runState = Animator.StringToHash("Base Layer.Running"); // do wykrywania stanu animacji na danej warstwie animatora
	private NavMeshAgent agent;

	void Start () {
		animator = gameObject.GetComponent<Animator>();
	}
	
	public void walkRun (NavMeshAgent a) {
		startWalkRun = true;
		agent = a;
	}
	public void attack () {
		animator.SetTrigger("isAttack");
	}

	void Update () {
		
		if(startWalkRun) {
			//Debug.Log(agent.remainingDistance);
			//move = Input.GetAxis("Vertical");
			if(move != 1)
				move+= 0.05f;

			if(agent.remainingDistance < 1.5 && move > 0.2){
				move-= 0.15f;
				if(agent.remainingDistance < 0.1){
					startWalkRun = false;
					move = 0;
				}	
			}
			animator.SetFloat("speed", move);
			
		}

		//Debug.Log(move);
		AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
		if(Input.GetKeyDown(KeyCode.Space) && stateInfo.fullPathHash == runState)
			animator.SetTrigger ("isJumping");

	}
}
