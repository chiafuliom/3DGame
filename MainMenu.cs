using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public void Teolvl(){
		SceneManager.LoadScene("Teo_lvl");
	}

	public void Mileslvl(){
		SceneManager.LoadScene("Miles_lvl");
	}

	public void Dadlvl(){
		SceneManager.LoadScene ("Daddy_lvl");
	}
	public void Menulvl(){
		SceneManager.LoadScene ("Main Menu");
	}
}
