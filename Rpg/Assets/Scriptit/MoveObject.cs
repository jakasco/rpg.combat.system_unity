using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

	public float nopeus;

	public float vihollisenNopeus;

	public GameObject grid;

	public bool vihollinenHyokkaa = false;

	public GameObject pelaaja;
	public GameObject vihollinen;

	private int PosX;
	private int PosY;

	private Vector3 liike;

	private Vector3 vihollinenLiike;

	//PELAAJAN LIIKUTTAMINEN MANUAALISESTI
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			pelaaja.gameObject.transform.Translate(Vector3.right * nopeus * Time.deltaTime);
		}


		//HIIRI

		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);
			if (hit) {
				//x ja y akselit hiirellä valitusta ruudusta
				float posX = hitInfo.transform.gameObject.GetComponent<Solu> ().position.x;
				float posY = hitInfo.transform.gameObject.GetComponent<Solu> ().position.z;

				PosX = (int)posX;
				PosY = (int)posY;

				liike = new Vector3 (PosX, 0, PosY);

				hitInfo.transform.gameObject.GetComponentInChildren<Solu> ().soluVarattu = true;

			}/**
			else {
				liike = pelaaja.gameObject.transform.position;
			}*/
		} 
		pelaaja.gameObject.transform.position = Vector3.MoveTowards(pelaaja.gameObject.transform.position, liike, Time.deltaTime*nopeus);

		if (vihollinenHyokkaa == true) {

			vihollinenLiike.x = PosX;
			vihollinenLiike.z = PosY+1;

		vihollinen.gameObject.transform.position = Vector3.MoveTowards(vihollinen.gameObject.transform.position, pelaaja.gameObject.transform.position, Time.deltaTime*nopeus);

		}
	}

}
