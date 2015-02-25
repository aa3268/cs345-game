using UnityEngine;
using System.Collections;

public class BulletEngine : MonoBehaviour {

	public GameObject particlePrefab;
	public float speed = 10f;
	private Vector3 forwardMove;

	void Start (){
		forwardMove = transform.up;

	}
	void FixedUpdate () {

		transform.Translate (forwardMove * speed * Time.deltaTime, Space.World);

	
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Asteroids" || col.gameObject.tag == "Entrance")
		{
			Destroy (col.gameObject);
		}

		Destroy(gameObject);
	}
}

