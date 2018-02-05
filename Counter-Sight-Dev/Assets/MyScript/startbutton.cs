using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class startbutton : MonoBehaviour {
	public Button startBtn;
	public Button fireBtn;
//	private PlaneFinderBehaviour PlaneFinderBehaviour;
	public GameObject PlaneFinder;
	public GameObject crosshair;

	// Use this for initialization
	void Start () {
		startBtn.onClick.AddListener (startNewGame);
	}
	
	void startNewGame(){

		PlaneFinder.gameObject.SetActive (false);
		startBtn.gameObject.SetActive (false);
		fireBtn.gameObject.SetActive (true);
		crosshair.gameObject.SetActive (true);
	}
}
