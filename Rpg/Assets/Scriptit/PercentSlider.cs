using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PercentSlider : MonoBehaviour {

	public GameObject pelaaja;

	public Text atHP;

	public Slider slider;

	public Text percent;

	public float atHPfloat;
	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		int luku = (int)slider.value;
		float hp = pelaaja.GetComponent<PelaajaOminaisuudet> ().hp;
		pelaaja.GetComponent<PelaajaOminaisuudet>().BreakHealth[2] = (float)hp*(float)luku*(float)0.01;
		atHP.text = pelaaja.GetComponent<PelaajaOminaisuudet> ().BreakHealth [2].ToString ();
		percent.text = luku.ToString() + "%";
	string hpConvert = atHP.text.ToString ();
		atHPfloat = float.Parse (hpConvert);
	}
}
