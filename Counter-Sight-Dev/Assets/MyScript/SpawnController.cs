using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnController : MonoBehaviour {
	public GameObject zombie;
	public Button startBtn;
	public float spawnZombieAmount;
	private float spawnRateDelay;


	// Use this for initialization
	void Start () {
		startBtn.onClick.AddListener (InvokeSpawnZombie);
	}

	void Update(){
//		transform.position = new Vector3 (Random.Range (-3f, 3f), 0, Random.Range (-3f, 3f));
	}
	void InvokeSpawnZombie(){
		
		spawnRateDelay = Random.Range (3f, 10f);
		InvokeRepeating ("SpawnZombie", spawnZombieAmount, spawnRateDelay);
	}

	void SpawnZombie(){
		
		transform.position = new Vector3 (Random.Range (-40f, 40f), 0, Random.Range (-40f, 40f));
//		Vector3 position = new Vector3 (Random.Range (-3f, 3f), 0, Random.Range (-3f, 3f));
		Instantiate (zombie, transform.position, Quaternion.identity);
	}
}
