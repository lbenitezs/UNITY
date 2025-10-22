using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanicas01 : MonoBehaviour {

	public GameObject laluzGO;
	public GameObject BuscoEsferaGO;
	public GameObject[] arrayCubos;


	void Start () {
		Debug.Log (gameObject.name); //muestra el nombre del propio objeto
		Debug.Log (laluzGO.name);
		BuscoEsferaGO = GameObject.Find ("Esfera");
		Debug.Log (BuscoEsferaGO.name);
		arrayCubos = GameObject.FindGameObjectsWithTag ("SoyUnCubo");
	}
	

	void Update () {
		
	}
}
