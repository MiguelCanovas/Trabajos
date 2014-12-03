using UnityEngine;
using System.Collections;

public class Inventario : MonoBehaviour {

	private bool llave = false;

	public bool getLlave(){
		return llave;
	}

	public void setLlave(){
		llave = true;
	}
}