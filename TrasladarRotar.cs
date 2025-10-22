using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrasladarRotar : MonoBehaviour {
	private Transform miTransform;
	public float velocidadTraslacion;
	public float velocidadRotacion;
	// Use this for initialization
	void Start () {
		miTransform = GetComponent <Transform> ();
	}

	// Update is called once per frame
	void Update () {
		miTransform.Translate (Vector3.right * velocidadTraslacion * Time.deltaTime);
		miTransform.Rotate (Vector3.up * velocidadRotacion * Time.deltaTime);
	}
}
