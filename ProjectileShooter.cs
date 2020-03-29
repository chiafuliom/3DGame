using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {
	GameObject prefab;
	// Use this for initialization
	void Start () {
		prefab = Resources.Load ("projectile") as GameObject;  // finds the projectile in the Resources folder and assigns the name prefab
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {  //if the left click is being pressed on the mouse
			GameObject projectile = Instantiate (prefab) as GameObject; //create the gameobject projectile
			//set the projectile position to appear at the player's position where the player is looking and add a bit to get the bullet in front of the view
			projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
			//to make it go forward assign a simple name rb to the rigidbody of the projectile
			Rigidbody rb = projectile.GetComponent<Rigidbody> ();
			//set the velocity in the direction the player is looking at whatever factor you want. In this case 40.
			rb.velocity = Camera.main.transform.forward * 40;
		}
	}

}
