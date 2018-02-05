using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour {
	public bool zombieAttacking;
	float timer;
	int timeBetweenAttacks;
	AudioSource attackSound;
	private GameController gameController;

	// Use this for initialization
	void Start () {
		timeBetweenAttacks = 2;
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");

		AudioSource[] audios = GetComponents<AudioSource> ();
		attackSound = audios [0];

		if(gameControllerObject != null){
			gameController = gameControllerObject.GetComponent<GameController> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(zombieAttacking && timer >= timeBetweenAttacks){
			Attack ();
		}	
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Player"){
			zombieAttacking = true;
		}
	}

	void OnCollisionExit(Collision col){
		if (col.gameObject.tag == "Player") {
			zombieAttacking = false;
		}
	}

	void Attack(){
		timer = 0; //timer reset to 0 after an attack
		GetComponent<Animator> ().Play("attack");
		gameController.zombieAttack (zombieAttacking);
		attackSound.Play ();

	}


}
