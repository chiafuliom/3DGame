using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.name == "Player")
		{
			other.transform.position = new Vector3(Random.Range(-60f, 400f), 100, Random.Range(220f, 630f));
		}
	}
}
