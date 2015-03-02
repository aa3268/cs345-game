using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {
	public Camera main;
	public Camera pause;
	public GameObject hud;


	public float rotationSpeed = 80f;
	public int shotCount;
	private float rotateValue = 0f;

	protected Vector3 move =  Vector3.zero;
	bool paused;



	// Update is called once per frame

	void Start()
	{
		Time.timeScale = 1;
		paused = false;
	}
	void Update () {

		rotateValue -= Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
		rotateValue = Mathf.Clamp (rotateValue, -35, 35);
		transform.localEulerAngles = new Vector3 (0f, 0f,rotateValue);
		if (Input.GetKeyDown (KeyCode.Escape) && !paused)
		{
			Time.timeScale = 0;
			paused = true;
			main.enabled = false;
			pause.enabled = true;
			hud.SetActive(false);
		}
		if (paused == true)
		{
			paused = false;
		}

	}
}
