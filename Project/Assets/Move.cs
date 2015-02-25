using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float moveSpeed;
	public GameObject nextLevel;
	public int count;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > 5) {
			transform.position -= new Vector3(0, moveSpeed * Time.deltaTime,0);
				}
		count = GameObject.FindGameObjectsWithTag ("Asteroids").Length;
		if(count == 0)
		{
			Instantiate(nextLevel, new Vector3(-4, 35, 0), nextLevel.transform.localRotation);
			Destroy(gameObject);
		}
	}
}
