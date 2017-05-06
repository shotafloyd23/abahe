using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour {
	public CoinRotor mover;
	public GameObject menu;
	void Start() {
		menu.SetActive (false);
		mover.enabled = true;
	}
	void Update () {
		if (menu.activeSelf) {
			mover.enabled = false;

		
	}
}
}
