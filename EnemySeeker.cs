using UnityEngine;

using System.Collections;




public class EnemySeeker : MonoBehaviour {




	public Transform target; //the enemy's target

	public int moveSpeed = 5; //move speed

	private int rotationSpeed = 3; //speed of turning

	private Transform myTransform; //current transform data of this enemy

	public void Awake()

	{

		myTransform = transform; //cache transform data for easy access/preformance

	}
		
	public void Start()

	{
		target = GameObject.FindWithTag("Player").transform; //target the player

		//	GetComponent.<Animation>().Play("orcwalk");

	}

	public void Update () {

		//rotate to look at the player

		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);


		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;




	}




}