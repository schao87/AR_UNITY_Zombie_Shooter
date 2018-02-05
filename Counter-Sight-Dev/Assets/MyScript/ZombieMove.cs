using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour {
	public float speed;
	AudioSource walkSound;
//	public GameObject target; //can't make this field and drop in bot prefab for some reason
	private GameObject bot;
	private GameObject parent;
	// Use this for initialization
	void Start () {
		parent = GameObject.FindGameObjectWithTag ("groundPlaneStage");
		bot = GameObject.FindWithTag ("Player"); //prefab zombie finds object with player tag
		AudioSource[] audios = GetComponents<AudioSource> ();
		walkSound = audios [1];
		StartCoroutine ("WalkSound");
		transform.SetParent (parent.transform);
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		transform.LookAt (bot.transform.position);
		transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0); //prevents zombie from tilting up and down
	}

	IEnumerator WalkSound(){
		int randomNum = Random.Range (5, 30);
		yield return new WaitForSeconds(randomNum);
		walkSound.Play ();
		StartCoroutine ("WalkSound");
	}
}
