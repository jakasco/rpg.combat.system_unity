using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LahiTaistelu : MonoBehaviour {

	public GameObject pelaajaLiikuAutomaattisesti;

	public float pSpeed = 1f;

	public float vSpeed = 3f;

	public float tekstinNousu = 1f;

	private float pelaajaLyoAika;

	private float vihollinenLyoAika;

	private float PelaajanLyontiNopeus;

	private float VihunLyontiNopeus;

	private float time = 1f;

	public GameObject vihollinen;

	public GameObject pelaaja;

	public GameObject pelaajaHealth;

	public GameObject pelaajaDamage;

	public GameObject vihollinenHealth;

	public GameObject vihollinenDamage;

	public Text UIplayerHP;

	public Text UIEnemyHP;

	private int maxHealthPlayer;

	private int maxHealthEnemy;

	public int pHP;

	public int vHP;

	public bool fightBreak = false;
	// Use this for initialization

	void Start () {

		pHP= (int)pelaaja.GetComponent<PelaajaOminaisuudet> ().hp;

		maxHealthEnemy = vHP;
		maxHealthPlayer = pHP;

		pelaajaHealth.GetComponent<TextMesh> ().text = pHP.ToString();
		vihollinenHealth.GetComponent<TextMesh> ().text = vHP.ToString();

		UIplayerHP.text = pHP.ToString();
		UIEnemyHP.text = vHP.ToString();
	}

	public void fight(){

		if (fightBreak == true) {

			if (PelaajanLyontiNopeus <= 0) {
		
				PelaajaHyokkaa ();
			}
			if (VihunLyontiNopeus <= 0) {
				VihollinenHyokkaa ();
			}
	
		}
	}

	public void PelaajaHyokkaa(){

		pelaajaLyoAika = tekstinNousu;


		PelaajanLyontiNopeus = pSpeed;

		int randomDMG = UnityEngine.Random.Range (10, 100);
		pelaajaDamage.GetComponent<TextMesh> ().text = randomDMG.ToString ();
		vHP = vHP - randomDMG;



		if (vHP <= maxHealthEnemy / 5) {
			UIEnemyHP.color = Color.green;
		}

		if (vHP <= 0) {
			vHP=0;
			UIEnemyHP.color = Color.red;
		}

		vihollinenHealth.GetComponent<TextMesh> ().text = vHP.ToString ();
		UIEnemyHP.text = vHP.ToString ();
	}

	public void VihollinenHyokkaa(){

		VihunLyontiNopeus = vSpeed;

		vihollinenLyoAika = tekstinNousu;

		int randomDMG = UnityEngine.Random.Range (10, 100);
		vihollinenDamage.GetComponent<TextMesh> ().text = randomDMG.ToString ();
		pHP = pHP - randomDMG;


		if (pHP <= maxHealthPlayer / 5) {
			UIplayerHP.color = Color.green;
		}

		if (pHP <= 0) {
			pHP =0;
			UIplayerHP.color = Color.red;
		}

		pelaajaHealth.GetComponent<TextMesh> ().text = pHP.ToString ();
		UIplayerHP.text = pHP.ToString ();
	}
	// Update is called once per frame
	void Update () {







	

		pelaajaLyoAika -= Time.deltaTime;
		if (pelaajaLyoAika <= 0) {
			pelaajaLyoAika = 0;
		}

		if (pelaajaLyoAika >= 0.1) {
	
			pelaajaDamage.SetActive(true);
		} else {
			pelaajaDamage.SetActive(false);
	
		}

		VihunLyontiNopeus -= Time.deltaTime;
		if (VihunLyontiNopeus <= 0) {
			VihunLyontiNopeus = 0;
		}

		PelaajanLyontiNopeus -= Time.deltaTime;
		if (PelaajanLyontiNopeus <= 0) {
			PelaajanLyontiNopeus = 0;
		}

		vihollinenLyoAika -= Time.deltaTime;
		if (vihollinenLyoAika <= 0) {
			vihollinenLyoAika = 0;
		}

		if (vihollinenLyoAika >= 0.1) {
		
			vihollinenDamage.SetActive(true);
		} else {
			vihollinenDamage.SetActive(false);
		
		}
				//JOS VIHOLLINEN LÄHELLÄ, TAPPELE
	
	if(pelaajaLiikuAutomaattisesti.GetComponent<PelaajaLiikuAutomaattisesti>().lahella==true){
				fight ();
		}
	}
}
