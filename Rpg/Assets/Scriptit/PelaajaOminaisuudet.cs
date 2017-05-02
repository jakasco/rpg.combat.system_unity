using UnityEngine;
using System.Collections;

public class PelaajaOminaisuudet : MonoBehaviour {

	public int AseidenMaara;

	public int AttackienMaara;

	public GameObject menu;

	public float hp;

	public float[] BreakHealth;

	public int amountOfBreaks;

	public GameObject combatController;

	private bool suljeBreakit = false;
	// Use this for initialization
	void Start () {
	//	amountOfBreaks = BreakHealth.Length;
	}
	
	// Update is called once per frame
	void Update () {

		float breakhp = menu.GetComponent<PercentSlider> ().atHPfloat;

		breakhp = BreakHealth [2];

		float playerHP = combatController.GetComponent<LahiTaistelu> ().pHP;
		//fightbreak
		if (suljeBreakit == false) {
			if (playerHP <= BreakHealth [amountOfBreaks]) {
		
				combatController.GetComponent<FightBreak> ().Stop ();

				amountOfBreaks -= 1;

				Debug.Log (amountOfBreaks + " breakkien määrä");
			}
		}
		if (amountOfBreaks <= 0) {
			suljeBreakit = true;
		}
		}


}
