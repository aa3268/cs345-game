using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
	public Camera pause;
	public Camera main;
	public GameObject hud;

	public void Continue()
	{
		Time.timeScale = 1;
		hud.SetActive (true);
		pause.enabled = false;
		main.enabled = true;
	}
	public void Quit()
	{
		Time.timeScale = 1;
		Application.LoadLevel (0);

	}
}
