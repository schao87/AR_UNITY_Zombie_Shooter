using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour {
	public int health;
	private Collider boxCollider;
	// Use this for initialization
	void Start(){
		boxCollider = GetComponent<BoxCollider> () as BoxCollider;
	}
	void Update () {
		ZombieDie ();
	}
	

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "ammo")
		{
			health -= 10;

		}
	}

	void ZombieDie(){
		if (health <= 0){
			transform.Translate (0,0,0);
			boxCollider.enabled = false;

			Destroy (gameObject,1);
			GetComponent<Animator> ().Play("back_fall");
		}
	}
}
