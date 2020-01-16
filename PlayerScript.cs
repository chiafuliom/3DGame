using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public GUIText countText;
	public GUIText winText;
	public GUIText timerText;
	public GUIText loseText;
	public float speed;
	public int count;
	public float timeLeft;
	public float totalTime;
	public bool gameWon = false;
	// Use this for initialization

	void Start(){

		count = 0;
		SetCountTimerText ();
		winText.text = "";
		timerText.text = "";
		loseText.text = "";
		totalTime = 20;
		timeLeft = totalTime;
		gameWon = false;
		timerText.text = "Timer: " + timeLeft.ToString ();
	}
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
		timerText.text = "Timer: " + timeLeft.ToString ();
		if (gameWon == false) {
			timeLeft -= Time.deltaTime; 
			if (timeLeft < 0) { 
				loseText.text = "YOU LOSE!!!";
				gameObject.SetActive (false);
				timerText.text = "Timer: 0.0";
			}
		}

			

	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Pickup")
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountTimerText();

		}

	}
	void SetCountTimerText()
	{
		countText.text = "Count: " + count.ToString();
		if (count == 10) {
			winText.text = "YOU WIN!!!!";
			gameWon = true;
		

		}
	}

	
	

}