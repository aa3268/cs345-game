using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public Camera main;
	public Camera info;

	public void StartGame()
	{
		Application.LoadLevel(1);
	}
	public void QuitGame()
	{
		Application.Quit ();
	}
	public void Info()
	{
		main.enabled = false;
		info.enabled = true;
	}
}
