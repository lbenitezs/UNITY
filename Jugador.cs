using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {
	public GameObject enemigoGO;
	public Enemigo enemigoScript;

	// Use this for initialization
	void Start () {
		enemigoGO = GameObject.Find ("ElEnemigo");
		enemigoScript = enemigoGO.GetComponent <Enemigo> ();

	}


	void Update () {
		if (enemigoScript.enemigoActivo == false) {
			enemigoGO.SetActive (false);
		} else {
			enemigoGO.SetActive (true);

		}
	}
}
