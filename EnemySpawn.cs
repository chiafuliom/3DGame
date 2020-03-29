using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	public GameObject[] enemies;
	public int amount;
	private Vector3 spawnPoint;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () 
	{
		enemies = GameObject.FindGameObjectsWithTag ("Deadly");
		amount = enemies.Length;
		if (amount != 5) 
		{
			InvokeRepeating ("spawnEnemy", 1, 10f);
		}
	}
	void spawnEnemy()
	{
		spawnPoint.x = Random.Range (0,490);
		spawnPoint.y = 1;
		spawnPoint.z = Random.Range (0,490);

		Instantiate (enemies [UnityEngine.Random.Range (0, enemies.Length)],spawnPoint, Quaternion.identity);
		CancelInvoke();
	}
}
