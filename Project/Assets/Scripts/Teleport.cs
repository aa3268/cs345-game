using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	
	public GameObject projectilePrefab;
	
	public Transform ShotSpawn;
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col) 
	{
			GameObject clone = Instantiate (projectilePrefab, ShotSpawn.position, ShotSpawn.rotation) as GameObject;
	}
}

