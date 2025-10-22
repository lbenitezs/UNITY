using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisComponentes : MonoBehaviour {

	public Transform transformLuz;
	public BoxCollider miCollider; //parte 3.2
	// Use this for initialization
	void Start () {
		miCollider = GetComponent<BoxCollider> ();//parte 3.2
		Debug.Log( gameObject.transform.position.x); 
		Debug.Log (transformLuz.position.y); 
		//Debug.Log (gameObject.coll); //parte 3
		Debug.Log (miCollider.enabled); //parte 3.2
		miCollider.enabled= false;
		Debug.Log (miCollider.enabled);
}
}