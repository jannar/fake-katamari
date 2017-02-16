using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour {

	GameObject katamari;

	float xScale;
	float yScale;
	float zScale;

	Vector3 scaleHalf;

	void Start () {

		//katamari = GameObject.Find ("Katamari");

//		xScale = this.gameObject.transform.localScale.x;
//		yScale = this.gameObject.transform.localScale.y;
//		zScale = this.gameObject.transform.localScale.z;
	}
		
//	void OnCollisionEnter (Collision other){
//
//		//pick it up
//		this.transform.parent = katamari.transform;
//
//		//make it smaller
//		Vector3 scaleHalf = new Vector3(xScale/2, yScale/2, zScale/2);
//		this.transform.localScale = scaleHalf;
//
//		Debug.Log ("picked up by the ball");
//
//	}

	void OnCollisionEnter (Collision other){

		// pick up object it touches
		if (!other.gameObject.name.Contains ("Plane")) {
			other.transform.parent = this.gameObject.transform;

			// make object smaller
			xScale = other.gameObject.transform.localScale.x;
			yScale = other.gameObject.transform.localScale.y;
			zScale = other.gameObject.transform.localScale.z;

			Vector3 scaleHalf = new Vector3 (xScale / 2, yScale / 2, zScale / 2);
		}
	}
}
