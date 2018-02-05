using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoGenerator : MonoBehaviour {
	
	public Button fireBtn;

	void Start(){
		fireBtn.onClick.AddListener (fireAmmo);
	}
	// Update is called once per frame
	void Update () {
		
	}

	void fireAmmo(){
//		Instantiate (AmmoPrefab, transform.position, transform.rotation);
		AmmoManager.SpawnAmmo (transform.position, transform.rotation);
	}
}
