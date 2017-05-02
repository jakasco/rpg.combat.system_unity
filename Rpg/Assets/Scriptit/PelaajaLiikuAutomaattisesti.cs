using UnityEngine;
using System.Collections;

public class PelaajaLiikuAutomaattisesti : MonoBehaviour {

	public GameObject movingController;

	public GameObject combat;

	public bool lahella = false;

	public GameObject pelaaja;

	public GameObject vihollinen;

	public float nopeus = 3f;

	public float etaisyysX = 1f;

	public float etaisyysZ = 0.9f;

	public bool liiku = false;

	public bool pakene = false;

	private int r = 1;
	private int ra = 1;
	// Use this for initialization
	void Start () {
	
		r = UnityEngine.Random.Range (-1, 1);
		ra = UnityEngine.Random.Range (-1, 1);

	}

	public void fight(){
		liiku = true;
		pakene = false;
		combat.GetComponent<FightBreak> ().Fight ();
	}

	public void escape(){
		liiku = false;
		pakene = true;
		combat.GetComponent<FightBreak> ().Fight ();
	}
	// Update is called once per frame
	void Update () {
	
		if (liiku == true) {

			if (vihollinen.transform.position.x - pelaaja.transform.position.x <= etaisyysX
			    
			    &&
			    
				vihollinen.transform.position.x - pelaaja.transform.position.x >= etaisyysX * -1
			    
			    && 
			    
				vihollinen.transform.position.z - pelaaja.transform.position.z <= etaisyysZ
			    
			    &&
			    
				vihollinen.transform.position.z - pelaaja.transform.position.z >= etaisyysZ * -1


			    ) {
				lahella = true;
			} else {
				lahella = false;
				if (pakene == false) {
					pelaaja.transform.position = Vector3.MoveTowards (pelaaja.gameObject.transform.position, vihollinen.gameObject.transform.position, Time.deltaTime * nopeus);
				}
			}

		}
		if (pakene == true) {
			movingController.GetComponent<VihollinenLiiku> ().pelaajaPakenee = true;

		



			Vector3 pakenemisEtaisyys = new Vector3 (vihollinen.transform.position.x + r, pelaaja.transform.position.y, vihollinen.transform.position.z+ra);

			pelaaja.transform.position = Vector3.MoveTowards (pelaaja.gameObject.transform.position, pakenemisEtaisyys, Time.deltaTime * nopeus);
			if(pelaaja.GetComponent<PelaajaSeinaCol>().ala==true){
				r =-1;
				ra = UnityEngine.Random.Range(-1,1);
			}
			if(pelaaja.GetComponent<PelaajaSeinaCol>().yla==true){
				r = 1;
				ra = UnityEngine.Random.Range(-1,1);
			}
			if(pelaaja.GetComponent<PelaajaSeinaCol>().oikea==true){
				ra = -1;
				r = UnityEngine.Random.Range(-1,1);
			}
			if(pelaaja.GetComponent<PelaajaSeinaCol>().vasen==true){
				ra =1;
				r = UnityEngine.Random.Range(-1,1);
			}

		}
	}
}
