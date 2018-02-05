using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ResetPosition : MonoBehaviour {
	public Button ResetBtn;
	public GameObject PlaneFinder;
	public Button startBtn;

	// Use this for initialization
	void Start () {
		ResetBtn.onClick.AddListener (ResetGame);
	}
	
	void ResetGame(){
		PlaneFinder.gameObject.SetActive (true);
		startBtn.gameObject.SetActive (true);
		ResetBtn.gameObject.SetActive (false);
	}
}
