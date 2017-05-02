using UnityEngine;
using System.Collections;

public class VihollinenRuutuCol : MonoBehaviour {

	public bool soluFull = false;

	public GameObject grid;
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag == "Ruutu") {
		//	Debug.Log ("vihollinen osuu ruutuun");
			//VÄRJÄÄ RUUTU
		//	coll.gameObject.GetComponentInChildren<Renderer>().material.color = Color.blue;
		//	coll.gameObject.GetComponentInChildren<Solu>().soluVarattu = true;
			if(coll.gameObject.GetComponentInChildren<Solu>().soluVarattu == true){
				soluFull = true;
		//		Debug.Log ("LÄHI TAISTELU");
			}
			else{

				soluFull = false;
			}
		}
	}

	void OnTriggerExit(Collider coll){
		if (coll.gameObject.tag == "Ruutu") {
		//	Debug.Log ("vihollinen osuu ruutuun");
		//	coll.gameObject.GetComponentInChildren<Renderer>().material.color = Color.green;
		//	coll.gameObject.GetComponentInChildren<Solu>().soluVarattu = false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
