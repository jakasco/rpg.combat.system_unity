using UnityEngine;
using System.Collections;

public class PelaajaSeinaCol : MonoBehaviour {

	public bool oikea = false;

	public bool vasen = false;

	public bool yla = false;

	public bool ala = false;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider coll){

		if(coll.gameObject.tag == "YlaSeina"){
		
			yla=true;
			ala=false;
			oikea=false;
			vasen= false;
		}

		if(coll.gameObject.tag == "AlaSeina"){
		
			ala=true;
			yla=false;
			oikea=false;
			vasen=false;
		}

		if(coll.gameObject.tag == "OikeaSeina"){

			oikea=true;
			vasen=false;
			yla=false;
			ala=false;
		}

		if(coll.gameObject.tag == "VasenSeina"){
		
			vasen=true;
			yla=false;
			oikea=false;
			ala=false;
		}
	}

	void OnTriggerExit(Collider coll){
		if(coll.gameObject.tag == "YlaSeina"){
			yla=false;
			ala=false;
			oikea=false;
			vasen= false;
		}
		
		if(coll.gameObject.tag == "AlaSeina"){
			yla=false;
			ala=false;
			oikea=false;
			vasen= false;
		}
		
		if(coll.gameObject.tag == "OikeaSeina"){
			yla=false;
			ala=false;
			oikea=false;
			vasen= false;
		}
		
		if(coll.gameObject.tag == "VasenSeina"){
			yla=false;
			ala=false;
			oikea=false;
			vasen= false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
