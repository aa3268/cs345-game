using UnityEngine;
using System.Collections;

public class SpaceJunk : MonoBehaviour {

	public float speed = 10f;
	private Vector3 forwardMove;
	public GameObject entrance_node;
	// Use this for initialization
	void Start () {
		forwardMove = transform.right;


	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (forwardMove * speed * Time.deltaTime * -1, Space.World );
	}

	void OnCollisionEnter(Collision col)
	{
		print("collider");
		if (col.gameObject.tag == "Teleport_Field") {

			transform.position = new Vector3(entrance_node.transform.position.x ,transform.position.y, transform.position.z);
		}
	}
}
