using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	public float speed = 5;
	public float angularSpeed = 30;
	public int number;//编号
	private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = this.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float v = Input.GetAxis ("VerticalPlayer0" + this.number);
		rigidbody.velocity = transform.forward * speed * v;
		float h = Input.GetAxis ("HorizontalPayer0" + this.number);
		rigidbody.angularVelocity = transform.up * angularSpeed * h;
	}
}