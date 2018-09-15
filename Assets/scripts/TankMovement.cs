using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	public float speed = 5;
	public float angularSpeed = 30;
	public int number; //编号
	private Rigidbody rigidbody;

	public AudioClip idleAudio;
	public AudioClip drivingAudio;

	private AudioSource audio;
	// Use this for initialization
	void Start () {
		rigidbody = this.GetComponent<Rigidbody> ();
		audio = this.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float v = Input.GetAxis ("VerticalPlayer0" + this.number);
		rigidbody.velocity = transform.forward * speed * v;
		float h = Input.GetAxis ("HorizontalPayer0" + this.number);
		rigidbody.angularVelocity = transform.up * angularSpeed * h;

		if (Mathf.Abs (h) > 0.1 || Mathf.Abs (v) > 0.1) {
			audio.clip = drivingAudio;
			if (audio.isPlaying == false)
				audio.Play ();
		} else {
			audio.clip = idleAudio;
			if (audio.isPlaying == false)
				audio.Play ();
		}
	}
}