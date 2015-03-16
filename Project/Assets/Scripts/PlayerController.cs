using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerController : MonoBehaviour {
	public Camera main;
	public Camera pause;


	public float rotationSpeed = 80f;
	public int shotCount;
	private float rotateValue = 0f;

	protected Vector3 move =  Vector3.zero;
	public bool paused;



	// Update is called once per frame

	void Start()
	{
		GameObject.Find ("Quit").SetActive (false);
		//Time.timeScale = 1;
		paused = false;
	}
	void Update () {
		rotateValue -= Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
		rotateValue = Mathf.Clamp (rotateValue, -45, 45);
		transform.localEulerAngles = new Vector3 (0f, 0f,rotateValue);
		/*
		if (GameObject.Find ("Starter").gameObject.transform.position.y < -399) 
		{
			if (Input.GetKeyDown (KeyCode.P) && !paused) {
				//GameObject.Find ("Quit").SetActive (true);
				Time.timeScale = 0;
				//GameObject.Find ("Timer(Clone)").SetActive(false);
				paused = true;
				main.enabled = false;
				pause.enabled = true;
			}
			if (paused == true) {
			//	paused = false;
			}

		}*/
	}
}
