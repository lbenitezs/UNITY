using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCinematico : MonoBehaviour {
	private Transform miTransform;
	public float velocidad;
	// Use this for initialization
	void Start () {
		miTransform = GetComponent <Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		//miTransform.position += new Vector3 (1, 0, 0);
		//miTransform.position += new Vector3 (1*velocidad, 0, 0);
		miTransform.position += new Vector3 (1*velocidad*Time.deltaTime, 0, 0);
	}
}
