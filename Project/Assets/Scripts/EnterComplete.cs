using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnterComplete : MonoBehaviour {
	bool fall;
	bool bounce;
	bool done;

	public GUIText timer;

	public float enterSpeed;
	public float bounceSpeed;
	public float fallSpeed;

	public float enterStop;
	public float bounceStop;
	public float fallStop;

	public GameObject starter;
	public GameObject[] asteroids;
	public int size;
	public bool clicked;
	// Use this for initialization
	void Start () {
		asteroids = GameObject.FindGameObjectsWithTag("Asteroids");
		size = asteroids.Length;
		Time.timeScale = 1;
		fall = false;
		bounce = false;
		done = false;
		clicked = false;
	}

	void Update()
	{
		timer = GameObject.Find ("Timer(Clone)").guiText;
		asteroids = GameObject.FindGameObjectsWithTag ("Asteroids");
		size = asteroids.Length;
		Debug.Log (timer.text.CompareTo ("00") == 0);
		if (size == 0 || (timer.text.CompareTo("00") == 0)) 
		{
			DropDown();
		}
	}
	void DropDown()
	{
		asteroids = GameObject.FindGameObjectsWithTag ("Asteroids");
		size = asteroids.Length;
		
		if (transform.position.y > enterStop && !done) {
			transform.position -= new Vector3 (0, enterSpeed * Time.deltaTime, 0);
			if (transform.position.y <= enterStop) {
				done = true;
				bounce = true;
			}
		}
		
		if (transform.position.y < bounceStop && bounce) {
			transform.position += new Vector3 (0, bounceSpeed * Time.deltaTime, 0);
			if (transform.position.y >= bounceStop) {
				fall = true;
				bounce = false;
			}
		}
		
		if (transform.position.y > fallStop && fall) {
			transform.position -= new Vector3 (0, fallSpeed * Time.deltaTime, 0);
		}




	}

}

