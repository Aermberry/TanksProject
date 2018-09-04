using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	public float speed = 5;
	public float angularSpeed = 30;
	private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = this.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float v = Input.GetAxis ("Vertical");
		rigidbody.velocity = transform.forward * speed * v;

		float h = Input.GetAxis ("Horizontal");
		
		rigidbody.angularVelocity = transform.up * angularSpeed * h;
	}
}