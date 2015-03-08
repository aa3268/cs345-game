using UnityEngine;
using System.Collections;

public class AsteroidMovement : MonoBehaviour {

	public float rotateValue = 0f;
	public float rotateClockwise = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (rotateClockwise == 1f) {
			transform.Rotate(0f, 0f, rotateValue * Time.deltaTime);
		} else {
			transform.Rotate(0f, 0f, rotateValue * Time.deltaTime);
		}

	}
}
