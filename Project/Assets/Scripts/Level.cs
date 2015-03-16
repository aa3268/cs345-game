using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
	public float moveSpeed;
	public GameObject nextLevel;
	public GameObject starter;
	public int count;
	public float stop;

	// Update is called once per frame
	void Update () {

		if (starter.transform.position.y < -399) 
		{
			if (transform.position.y > stop) {
					transform.position -= new Vector3 (0, moveSpeed * Time.deltaTime, 0);
			}
			if (GameObject.FindGameObjectsWithTag ("Asteroids").Length == 0) {
					Destroy (gameObject);
			}
		}
	}
}
