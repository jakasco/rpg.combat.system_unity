using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FightBreak : MonoBehaviour {

	public GameObject pelaaja;

	public bool fightNappula = false;

	public Slider timeSlider;

	public GameObject breakPanel;

	private float timeForBreak = 0;

	public GameObject movingController;

	public GameObject combatController;

	public bool fightBreak = false;
	// Use this for initialization
	void Start () {
		breakPanel.SetActive (false);
	}

	public void StartFight(){
		fightNappula = true;
	}
	public void StopFight(){
		fightNappula = false;
	}

	public void Fight(){

		timeForBreak = 0f;

	//	Debug.Log ("FIGHT");

		fightBreak = true;

		breakPanel.SetActive (false);
	}

	public void Stop(){

		if (pelaaja.GetComponent<PelaajaOminaisuudet> ().amountOfBreaks > 0) {

			breakPanel.SetActive (true);

			timeForBreak = 10f;

			//	Debug.Log ("BREAK");

			fightBreak = false;

		}
	}
	// Update is called once per frame
	void Update () {

		if (fightNappula == true) {

			timeSlider.value = timeForBreak;

			timeForBreak -= Time.deltaTime;

			if (timeForBreak <= 0) {
				timeForBreak = 0;
				fightBreak = true;
		
			} else {
		
				fightBreak = false;
			}

			//vihollinen liikkuu sekä taistelee on tosi/epätosi
			if (fightBreak == true) {
				movingController.GetComponent<VihollinenLiiku> ().liiku = true;
				movingController.GetComponent<PelaajaLiikuAutomaattisesti> ().liiku = true;
				combatController.GetComponent<LahiTaistelu> ().fightBreak = true;
				Fight ();
			} else {
				movingController.GetComponent<VihollinenLiiku> ().liiku = false;
				combatController.GetComponent<LahiTaistelu> ().fightBreak = false;
				movingController.GetComponent<PelaajaLiikuAutomaattisesti> ().liiku = false;
			}

		}
	}
}
