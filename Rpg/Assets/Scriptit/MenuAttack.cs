using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuAttack : MonoBehaviour {

	public GameObject pelaaja;

	public GameObject[] comboHit;

	// Use this for initialization
	void Start () {
		for(int i=0; i<5; i++){
			if(pelaaja.GetComponent<PelaajaOminaisuudet>().AttackienMaara > i){
			comboHit[i].SetActive(true);
			}
			else{
				comboHit[i].SetActive(false);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
