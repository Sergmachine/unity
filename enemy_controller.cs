using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_controller : MonoBehaviour {

	Animator anim;
	NavMeshAgent nav;
	public Transform camera;
	public Rigidbody sphere;
	CapsuleCollider col;

	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
		col = GetComponent<CapsuleCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (camera.position);
		//Debug.Log (anim.parameters);
	}

	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag == "bullet"){
			anim.SetFloat ("death", 1.5f);
			nav.enabled = false;
			col.enabled = false;

		}


	}
		
}
