using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{	
	public void StartGame()
	{
		Application.LoadLevel(3);
	}
	public void Info()
	{
		Application.LoadLevel (2);
	}
	public void QuitGame()
	{
		Application.Quit ();
	}
}
