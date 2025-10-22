using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTR : MonoBehaviour {
	private Transform miTransform;
	public float velocidadTraslacion= 2.0f;
	public float velocidadRotacion= 180.0f;
	// Use this for initialization
	void Start () {
		miTransform = GetComponent <Transform> ();
	}

	// Update is called once per frame
	void Update () {
		miTransform.Translate (Vector3.right * Input.GetAxis("Vertical")* velocidadTraslacion * Time.deltaTime);
		miTransform.Rotate (Vector3.up * Input.GetAxis("Horizontal")*  velocidadRotacion * Time.deltaTime);
	}
}
