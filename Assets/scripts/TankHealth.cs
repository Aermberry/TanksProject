using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

	public int hp = 100;
	public GameObject TankExplosion;
	public AudioClip tankExplosionAudio;

	public Slider hpSlider;

	private int hpTotal;
	// Use this for initialization
	void Start ()
	{
	    hpTotal = hp;
	}

	// Update is called once per frame
	void Update () {

	}

	void TakeDamage ()
	{
	    if (hp <= 0)
	        return; 

		hp -= Random.Range (10, 20);
		hpSlider.value=(float)hp/hpTotal;
		if (hp <= 0) { //收到伤害之后 血量为0 控制死亡效果
		AudioSource.PlayClipAtPoint(tankExplosionAudio,transform.position);
			GameObject.Instantiate (TankExplosion, transform.position + Vector3.up, transform.rotation);
			GameObject.Destroy (this.gameObject);
		}
	}

}