using UnityEngine;
using System.Collections;

public class PelaajaRuutuCollision : MonoBehaviour {

	public GameObject grid;

	public float posX;
	public float posY;
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag == "Ruutu") {

			posX = coll.gameObject.GetComponentInChildren<Solu>().position.x;
			posY = coll.gameObject.GetComponentInChildren<Solu>().position.z;
			coll.gameObject.GetComponentInChildren<Solu>().soluVarattu = true;
		}
	}

	void OnTriggerExit(Collider coll){
		if (coll.gameObject.tag == "Ruutu") {

			coll.gameObject.GetComponentInChildren<Solu>().soluVarattu = false;
		}
	}
	// Update is called once per frame
	void Update () {
	//	Debug.Log ("pos X: " + posX + ", pos Y: " + posY);
	}
}
