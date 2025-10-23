using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFisico : MonoBehaviour {
	public float fuerzaLineal;
	public float fuerzaGiro;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		
	}
	

	void FixedUpdate () { // se ejecuta cada 0.02s
		float aceleracion = Input.GetAxis ("Vertical");
		float giro  = Input.GetAxis ("Horizontal");
		rb.AddForce (transform.right* aceleracion * fuerzaLineal);
		rb.AddTorque (transform.up * giro * fuerzaGiro);
		
	}
}


