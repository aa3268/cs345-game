using UnityEngine;
using System.Collections;

public class BulletEngine : MonoBehaviour {

	bool visible;
	public float speed = 10f;
	private Vector3 forwardMove;
	public GameObject explosion;
	void Start (){
		forwardMove = transform.up;

	}
	void FixedUpdate () {
		visible = renderer.isVisible;
		if (!visible) {
			Destroy(gameObject);
				}
		transform.Translate (forwardMove * speed * Time.deltaTime, Space.World);

	
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Asteroids")
		{
			Instantiate(explosion, col.transform.position, col.transform.rotation);
			Destroy (col.gameObject);
		}
		/*
		else if(col.gameObject.tag == "Entrance")
		{
			Destroy (col.gameObject.transform.parent);
		}*/

		Destroy(gameObject);
	}
}

