using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	Rigidbody rb;
	float v;
	float h;
	float f;
	float f2;
	float x;
	bool test_cam;
	Transform tr;
	Vector3 rotation;
	public Rigidbody sphere;
	public Animator z_anim;
	public Transform dulo_tr;
	Rigidbody clone;
	public Camera camera_zoom;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
		test_cam = false;
	}
	
	// Update is called once per frame
	void Update () {
		v = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");
		f = Input.GetAxis ("Fire1");
		f2 = Input.GetAxis ("Fire2");
		x = Input.GetAxis ("Mouse X");
		Vector3 force = new Vector3 (0, 0, v);
		rb.AddForce (tr.forward * v * 100f);

		rotation = new Vector3 (0,x,0);
		tr.Rotate (rotation * 5f);

		if (f2 > 0) {
			if (test_cam == false) {
				test_cam = true;
				camera_zoom.GetComponent<Camera> ().enabled = true;
			} else {
				test_cam = false;
				camera_zoom.GetComponent<Camera> ().enabled = false;
			}
		}

		if(f>0){
			clone = Instantiate (sphere,dulo_tr.position,dulo_tr.rotation);
			clone.AddForce (tr.forward * 5000f);
		}
	}

	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag == "enemy") {
			
		}
	}

}
