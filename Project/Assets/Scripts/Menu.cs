using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{	
	public AudioClip clip;

	public void StartGame()
	{
		Application.LoadLevel(1);
	}
	public void QuitGame()
	{
		Application.Quit ();
	}

	public void OnMouseEnter()
	{
		audio.PlayOneShot (clip);
	}
}
