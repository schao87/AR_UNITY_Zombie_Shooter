using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject bloodyScreen;
	public Text healthText;
	public int health;
	public GameObject zombie;
	public Button startBtn;
	public GameObject PlaneFinder;
	// Use this for initialization
	void Start () {
		health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if(health <= 0){
			SceneManager.LoadScene ("GameOver");
			PlaneFinder.gameObject.SetActive (true);
		}
	}
	public void zombieAttack(bool zombieAttacking){
		bloodyScreen.gameObject.SetActive (true);
		StartCoroutine (wait2Seconds());
		health -= 1;

		string stringHealth = health.ToString();
		healthText.text = "" + stringHealth;
	}
	IEnumerator wait2Seconds(){
		yield return new WaitForSeconds (2f);
		bloodyScreen.gameObject.SetActive (false);
	}
}
