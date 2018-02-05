using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour {

	public float LifeTime = 3f;

	void OnEnable(){ //this is called when game object is activated
		CancelInvoke ();
		Invoke("HideAmmo", LifeTime);
	}

	void HideAmmo(){
		gameObject.SetActive (false);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "zombie")
		{
			gameObject.SetActive (false);
		}
	}
}
