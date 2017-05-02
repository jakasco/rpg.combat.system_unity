using UnityEngine;
using System.Collections;

public class OpenMenu : MonoBehaviour {

	public GameObject Menu;

	// Use this for initialization
	void Start () {
		Menu.SetActive (false);
	}

	public void openMenu(){

		Menu.SetActive (true);
	}

	public void closeMenu(){

		Menu.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
