using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {

	public GameObject shellPrefab;
	private Transform FirePosition;
	public float shellSpeed=10;
	public KeyCode fireKey = KeyCode.Space;

	public AudioClip shotAudio;
	// Use this for initialization
	void Start () {
		FirePosition = transform.Find ("FirePosition");

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (fireKey)) {//如果接收到发射指令
		AudioSource.PlayClipAtPoint(shotAudio,transform.position);
		GameObject go=GameObject.Instantiate (shellPrefab, FirePosition.position, FirePosition.rotation)as GameObject;//将实例化的对象作为一个GameObject对象
		go.GetComponent<Rigidbody>().velocity=go.transform.forward*shellSpeed;
		}

	}
}