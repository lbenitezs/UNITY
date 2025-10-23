using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour {
	private float fuerzaLineal=10.0f;
	private float fuerzaGiro=5.0f;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {// crear variable del tipo Rigidbody
		 rb = GetComponent <Rigidbody> ();
		
	}
	

	void FixedUpdate () { // se ejecuta cada 0.02s de forma constante e independiente a FPS
		float aceleracion = Input.GetAxis ("Vertical");
		float giro = Input.GetAxis ("Horizontal");
		rb.AddForce (transform.forward * aceleracion * fuerzaLineal);
		rb.AddTorque (transform.up * giro * fuerzaGiro);
	
	}
	/*void OnCollisionEnter (Collision coll){

		if (coll.gameObject.tag == "Bonus") {
			Destroy (coll.gameObject);
		}
		if (coll.gameObject.tag == "Enemigo") {
			Destroy (this.gameObject);
		}
	}*/
	void OnTriggerExit(Collider other){

		if (other.gameObject.tag == "Bonus") {
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "Enemigo") {
			Destroy (this.gameObject);
		}
	}


}
