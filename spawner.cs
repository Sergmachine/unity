using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawner : MonoBehaviour {

	Transform spawn_tr;
	public GameObject zombie;
	GameObject clone;

	// Use this for initialization
	void Start () {
		spawn_tr = GetComponent<Transform>();
		InvokeRepeating ("Spawner",10f,10f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawner(){
		clone = Instantiate (zombie,spawn_tr.position,spawn_tr.rotation);
		clone.GetComponent<NavMeshAgent> ().enabled = true;
		clone.GetComponent<CapsuleCollider> ().enabled = true;
	}

}
	
