
//This script should be attached to an emitter gameobject.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject bullet;
	public float speed = 50f;
	// Use this for initialization
	void Start () {
		StartCoroutine(Wait2Shoot());
	}
	
	// Update is called once per frame
	void Update () {
	//	transform.Rotate(new Vector3 (15,30,45)*Time.deltaTime);

		//Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody> ();
		//instBulletRigidbody.AddForce (Vector3.forward * speed);
	}

	private IEnumerator Wait2Shoot(){
		yield return new WaitForSeconds (.5f);
		GameObject instBullet = Instantiate (bullet, transform.position, Quaternion.identity) as GameObject;
		Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody> ();
		instBulletRigidbody.AddForce (Vector3.forward * speed);
		StartCoroutine(Wait2Shoot());
	}
}
