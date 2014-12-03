using UnityEngine;
using System.Collections;

public class PuertaAnimacion : MonoBehaviour {


	private  GameObject bisagra;
	private bool cerrada = true;

	// Use this for initialization
	void Start () {
		bisagra = GameObject.Find ("bisagra")as GameObject;
	
	}
	
	void OnTriggerEnter (Collider otro){
		Debug.Log (otro.name);
		if (otro.GetComponent<Inventario>().getLlave() && cerrada) {
			bisagra.GetComponent<Animation>().Play ("AbrirPuerta");
			cerrada = false;
		}
		
	}

	

}