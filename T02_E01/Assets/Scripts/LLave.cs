using UnityEngine;
using System.Collections;

public class LLave : MonoBehaviour {

	private Inventario inventario;

	void OnTriggerEnter(Collider otro){
		if(otro.tag == "Player"){
			otro.gameObject.GetComponent<Inventario>().setLlave ();
			Destroy(this.gameObject);
		}
	}

	

}
