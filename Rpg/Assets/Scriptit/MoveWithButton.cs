using UnityEngine;
using System.Collections;

public class MoveWithButton : MonoBehaviour {

	public float nopeus = 2F;

	public GameObject grid;

	public GameObject pelaaja;

	private float PosX;
	private float PosY;

	private Vector3 liike;
	// Use this for initialization
	
	//PELAAJAN LIIKUTTAMINEN MANUAALISESTI NUOLILLA
	
	void Start () {
	
	}

	public void Liiku(){

		PosX = pelaaja.GetComponent<PelaajaRuutuCollision> ().posX;
		PosY = pelaaja.GetComponent<PelaajaRuutuCollision> ().posY;

		liike = new Vector3 (PosX+1, 0, PosY);
		grid.GetComponentInChildren<Solu> ().position.x = liike.x;
		grid.GetComponentInChildren<Solu> ().position.z = liike.z;
		pelaaja.gameObject.transform.position = Vector3.Lerp(pelaaja.gameObject.transform.position, grid.GetComponentInChildren<Solu> ().position, Time.deltaTime*nopeus);
	}

	public void LiikuToiseenSuuntaan(){
		
		PosX = pelaaja.GetComponent<PelaajaRuutuCollision> ().posX;
		PosY = pelaaja.GetComponent<PelaajaRuutuCollision> ().posY;
		
		liike = new Vector3 (PosX-1, 0, PosY);
		grid.GetComponentInChildren<Solu> ().position.x = liike.x;
		grid.GetComponentInChildren<Solu> ().position.z = liike.z;
		pelaaja.gameObject.transform.position = Vector3.Lerp(pelaaja.gameObject.transform.position, grid.GetComponentInChildren<Solu> ().position, Time.deltaTime*nopeus);
	}

	public void LiikuOikea(){
		PosX = pelaaja.GetComponent<PelaajaRuutuCollision> ().posX;
		PosY = pelaaja.GetComponent<PelaajaRuutuCollision> ().posY;
		
		liike = new Vector3 (PosX, 0, PosY+1);
		grid.GetComponentInChildren<Solu> ().position.x = liike.x;
		grid.GetComponentInChildren<Solu> ().position.z = liike.z;
		pelaaja.gameObject.transform.position = Vector3.Lerp(pelaaja.gameObject.transform.position, grid.GetComponentInChildren<Solu> ().position, Time.deltaTime*nopeus);
	}

	public void LiikuVasen(){

		PosX = pelaaja.GetComponent<PelaajaRuutuCollision> ().posX;
		PosY = pelaaja.GetComponent<PelaajaRuutuCollision> ().posY;
		
		liike = new Vector3 (PosX, 0, PosY-1);
		grid.GetComponentInChildren<Solu> ().position.x = liike.x;
		grid.GetComponentInChildren<Solu> ().position.z = liike.z;
		pelaaja.gameObject.transform.position = Vector3.Lerp(pelaaja.gameObject.transform.position, grid.GetComponentInChildren<Solu> ().position, Time.deltaTime*nopeus);
	}
	// Update is called once per frame
	void Update () {
		pelaaja.gameObject.transform.position = Vector3.MoveTowards(pelaaja.gameObject.transform.position, liike, Time.deltaTime*nopeus);
	}
}
