using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	
	public GameObject projectilePrefab;
	public GameObject mainAsteroid;

	public Transform ShotSpawn;
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col) 
	{
			if (col.gameObject.tag == "bullet") {
						GameObject clone = Instantiate (projectilePrefab, ShotSpawn.position, ShotSpawn.rotation) as GameObject;
			Destroy (gameObject.transform.parent.gameObject);
		    }
	}
}

