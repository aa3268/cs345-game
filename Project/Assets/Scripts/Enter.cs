using UnityEngine;
using System.Collections;

public class Enter : MonoBehaviour {
	bool fall;
	bool bounce;
	bool done;

	public float enterSpeed;
	public float bounceSpeed;
	public float fallSpeed;

	public float enterStop;
	public float bounceStop;
	public float fallStop;
	public float exitStop;

	public bool clicked;
	public Ready readyCheck;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		fall = false;
		bounce = false;
		done = false;
		readyCheck = readyCheck.GetComponent<Ready> ();
		clicked = false;
	}

	void Update()
	{
			clicked = readyCheck.clicked;
			if(transform.position.y > enterStop && !done){
				transform.position -= new Vector3 (0, enterSpeed * Time.deltaTime, 0);
				if(transform.position.y <= enterStop)
				{
					done = true;
					bounce = true;
				}
			}

			if (transform.position.y < bounceStop && bounce) {
				transform.position += new Vector3 (0, bounceSpeed * Time.deltaTime, 0);
				if(transform.position.y >= bounceStop)
				{
					fall = true;
					bounce = false;
				}
			}

			if (transform.position.y > fallStop && fall) {
				transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
			}
			if (clicked && transform.position.y > exitStop) {
				transform.position -= new Vector3(0, enterSpeed * Time.deltaTime, 0);
			}
			//done = true;
	}

}

