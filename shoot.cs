﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag == "enemy"){

		}

		if (arg.gameObject.tag != "MainCamera"){
			Destroy(gameObject);
		}

		if (arg.gameObject.tag == "MainCamera"){
			Destroy(gameObject);
		}

	}
}
