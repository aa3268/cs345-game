using UnityEngine;
using System.Collections;

public class InfoButtons : MonoBehaviour {

	// Use this for initialization
	public void StartLevel()
	{
		Application.LoadLevel (3);
	}
	
	// Update is called once per frame
	public void GoBack ()
	{
		Application.LoadLevel (1);
	}
}
