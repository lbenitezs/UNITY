using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosEsfera : MonoBehaviour {

	void Awake(){
		Debug.Log ("Estoy en el Awake de la esfera");
	}
	void Start () {
		Debug.Log ("Estoy en el start de la esfera");
	}
	

	void Update () {
		Debug.Log ("Estoy en el update de la esfera");

		
	}


	void OnEnable () {
		Debug.Log ("Se activa la esfera");
	}
	void OnDisable () {
		Debug.Log ("Se desactiva la esfera");
	}
	void OnMouseDown () {
		Debug.Log ("He hecho click sobre la esfera");
	}
	void OnMouseEnter () {
		Debug.Log ("He entrado en la esfera");
	}
	void OnMouseUp () {
		Debug.Log ("He soltado el click sobre la esfera");
	}
	void OnMouseOver () {
		Debug.Log ("Estoy sobre la esfera");
	}
}

