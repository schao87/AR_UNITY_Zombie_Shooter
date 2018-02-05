using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRay : MonoBehaviour {
//	public Transform Target;
	public float damage;
	public float range;
	public Camera camera;
	public Vector3 rayHit;
	public LayerMask layerMask;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		hitInfoCreation ();
	}

	public void hitInfoCreation(){
		RaycastHit hitInfo;
		//		Debug.DrawRay(camera.transform.position, camera.transform.forward * 500, Color.red);

		if (Physics.Raycast (camera.transform.position, camera.transform.forward, out hitInfo, range, layerMask)) {
			Debug.DrawRay(camera.transform.position, camera.transform.forward * 500, Color.red);
			rayHit = hitInfo.point;
		}

//		Vector3 hitPosition = new Vector3( hitInfo.point.x, Target.transform.position.y, hitInfo.point.z );

		//Vector3 rayHit = new Transform (hitInfo.transform.position.x, hitInfo.transform.position.y, hitInfo.transform.position.z);
	}
}
