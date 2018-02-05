using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CharControllerScript : MonoBehaviour {

//	private Vector3 thirdPerson_view_rotation = Vector3.zero;
//	public float walkSpeed = 6.75f;
//	public float runSpeed = 10f;
//	public float crouchSpeed = 4f;
//	public float jumpSpeed = 8f;
//	public float gravity = 20f;
//	private float speed;
//	private bool is_moving, is_grounded, is_crouching;
//
//	private float inputX, inputY;
//	private float inputX_Set, inputY_Set;
//	private bool limitDiagonalSpeed = true;
//	private float antiBumpFactor = .75f;
//
//	private CharacterController charController;
//	private Vector3 moveDirection = Vector3.zero;

	[SerializeField] float moveSpeed;
//	[SerializeField] float jumpHeight;
	private Rigidbody charRigidbody;
//	private Animator anim;


	// Use this for initialization
	void Start () {
//		charController = GetComponent <CharacterController> ();
//		speed = walkSpeed;
//		is_moving = false;

		charRigidbody = GetComponent<Rigidbody> ();
//		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 moveChar = new Vector3 (CrossPlatformInputManager.GetAxis ("Horizontal"), 0, CrossPlatformInputManager.GetAxis ("Vertical"));
		transform.position += moveChar * Time.deltaTime * moveSpeed;
	}
}
