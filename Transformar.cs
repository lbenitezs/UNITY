using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformar : MonoBehaviour {
	private Transform miTransform = null;
	public GameObject otroGO;
	private Transform transformOtroGO;


	// Use this for initialization
	void Start () {
		miTransform = GetComponent <Transform> ();
		miTransform.position = new Vector3 (2, 2, 2);

		otroGO = GameObject.Find ("EsferaRoja");
		transformOtroGO = otroGO.GetComponent <Transform> ();
		transformOtroGO.position = new Vector3 (-2, -2, -2);

	}

	// Update is called once per frame
	void Update () {
		
	}
}
