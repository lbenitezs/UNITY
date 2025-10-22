using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jerarquia : MonoBehaviour {
	private Transform miTransform;
	// Use this for initialization
	void Start () {
		miTransform = GetComponent <Transform> ();
		//recorrer la jerarquia
		for (int i=0; i< miTransform.childCount; i++){
			Transform hijoTransform = miTransform.GetChild (i);
			Debug.Log (hijoTransform.gameObject.name);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
