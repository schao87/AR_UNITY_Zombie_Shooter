using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmmoManager : MonoBehaviour {

	public GameObject AmmoPrefab;
	public int PoolSize = 25;

	private GameObject[] AmmoArray;

	public static AmmoManager AmmoManagerSingleton = null;

	public Queue<Transform> AmmoQueue = new Queue<Transform> ();

	// Use this for initialization
	void Awake () {
		if(AmmoManagerSingleton != null){
			DestroyImmediate (gameObject);
			return; //exits awake function
		}
		AmmoManagerSingleton = this;
	}

	void Start(){
		AmmoArray = new GameObject[PoolSize];

		for(int i = 0; i < PoolSize; i++){
			AmmoArray [i] = Instantiate (AmmoPrefab, Vector3.zero, Quaternion.identity) as GameObject;
			Transform ObjTransform = AmmoArray[i].GetComponent<Transform> (); //objTransform is the transform of the ammo object
			ObjTransform.parent = transform; //makes ammo prefab a child of ammo manager
			AmmoQueue.Enqueue (ObjTransform);
			AmmoArray [i].SetActive (false); //hides ammo after adding to array
		}
	}

	public static Transform SpawnAmmo(Vector3 Position, Quaternion Rotation){ //static function allows any object outside of this objet to call on it
		Transform SpawnedAmmo = AmmoManagerSingleton.AmmoQueue.Dequeue (); // removes first ammo in front of queue and stores it in spawnedAmmo
		SpawnedAmmo.gameObject.SetActive (true); //enables the ammo to make it visible
		SpawnedAmmo.position = Position;
		SpawnedAmmo.rotation = Rotation;

		AmmoManagerSingleton.AmmoQueue.Enqueue (SpawnedAmmo); //adds ammo back to the end of queue

		return SpawnedAmmo; //returns reference to this transform in case any other function needs access to the ammo object that has been generated here
	}
}
