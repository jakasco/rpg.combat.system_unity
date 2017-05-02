using UnityEngine;
using System.Collections;

public class VihollinenLiiku : MonoBehaviour {

	public bool liiku = false;

	public float nopeus = 2F;

	public float etaisyysX = 1f;

	public float etaisyysZ = 0.9f;

	public GameObject grid;

	public GameObject pelaaja;

	public GameObject vihollinen;

	private Vector3 liike;

	public bool pelaajaPakenee = false;

	private float PosX;
	private float PosY;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//vihollinen on 1 ruudun päässä
		/**
		if (vihollinen.transform.position.x - pelaaja.transform.position.x <= etaisyysX && vihollinen.transform.position.z - pelaaja.transform.position.z <= etaisyysZ ){
			Debug.Log("pyshdy!");
		}
		*/
	//	Debug.Log (vihollinen.transform.position - pelaaja.transform.position + " etäisyys");
		if (liiku == true) {
			float etaX = vihollinen.transform.position.x - pelaaja.transform.position.x;
			float etaY = vihollinen.transform.position.z - pelaaja.transform.position.z;

			PosX = pelaaja.GetComponent<PelaajaRuutuCollision> ().posX;
			PosY = pelaaja.GetComponent<PelaajaRuutuCollision> ().posY;

			liike = new Vector3 (PosX, 0, PosY);
			grid.GetComponentInChildren<Solu> ().position.x = liike.x;
			grid.GetComponentInChildren<Solu> ().position.z = liike.z;

		
			if (pelaajaPakenee == false) {
				if (vihollinen.transform.position.x - pelaaja.transform.position.x <= etaisyysX

			    &&

					vihollinen.transform.position.x - pelaaja.transform.position.x >= etaisyysX * -1

			    && 

					vihollinen.transform.position.z - pelaaja.transform.position.z <= etaisyysZ

			    &&

					vihollinen.transform.position.z - pelaaja.transform.position.z >= etaisyysZ * -1

			    ) {
					//	Debug.Log ("viholline on lähellä");
			
				} else {
					vihollinen.gameObject.transform.position = Vector3.MoveTowards (vihollinen.gameObject.transform.position, grid.GetComponentInChildren<Solu> ().position, Time.deltaTime * nopeus);
				}

			}
			else{
				vihollinen.gameObject.transform.position = Vector3.MoveTowards (vihollinen.gameObject.transform.position, grid.GetComponentInChildren<Solu> ().position, Time.deltaTime * nopeus);
			}
		}
	}
}
