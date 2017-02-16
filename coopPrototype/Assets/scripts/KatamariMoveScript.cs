using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatamariMoveScript : MonoBehaviour {

	// get the rigidbody
	Rigidbody rb;

	// a "thrust" multiplier
	public float thrust;

	// Use this for initialization
	void Start () {

		rb = this.GetComponent<Rigidbody> ();

	}
	
	// FixedUpdate is for physics things
	void FixedUpdate () {

		// make it roll
		if (Input.GetMouseButton (0)) {
			rb.AddForce (transform.forward * thrust, ForceMode.Acceleration);
			Debug.Log ("it's moving " + this.transform.position.x + " + " + this.transform.position.z);
		}

		// make it roll...backwards
		// which, by the way, is nauseating
		if (Input.GetMouseButton (1)) {
			rb.AddForce (transform.forward * (thrust * -1), ForceMode.Acceleration);
			Debug.Log ("it's regressing " + this.transform.position.x);
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			rb.AddForce (transform.right * (thrust * -1), ForceMode.Acceleration);
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			rb.AddForce (transform.right * (thrust), ForceMode.Acceleration);
		}
		
	}
}
