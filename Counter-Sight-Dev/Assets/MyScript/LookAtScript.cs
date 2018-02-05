using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour {
//	public Transform Target;
	public cameraRay cr;

	// Use this for initialization
	void Start () {

	 

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 targetPosition = new Vector3(cr.rayHit.x, transform.position.y, cr.rayHit.z );

		Quaternion rotation = Quaternion.LookRotation (targetPosition - transform.position); 
		transform.rotation = Quaternion.Lerp (transform.rotation, rotation, Time.deltaTime * 20f);

		//		transform.LookAt (targetPosition);
	}
}
