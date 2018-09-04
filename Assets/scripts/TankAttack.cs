using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {

	public GameObject shellPrefab;
	public Transform FirePosition;

	public KeyCode fireKey = KeyCode.Space;
	// Use this for initialization
	void Start () {
		FirePosition = transform.Find ("FirePosition");

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (fireKey)) {//如果接收到发射指令
			GameObject.Instantiate (shellPrefab, FirePosition.position, FirePosition.rotation);
		}

	}
}