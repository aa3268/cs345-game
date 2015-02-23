using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {

	public float cooldown = 0.2f;
	float cooldownRemaining = 0;

	public GameObject projectilePrefab;

	public Transform ShotSpawn;

	// Update is called once per frame
	void Update () {
		cooldownRemaining -= Time.deltaTime;

		if (Input.GetKey (KeyCode.Space) && cooldownRemaining <= 0) 
		{

			cooldownRemaining = cooldown;

			GameObject clode = Instantiate (projectilePrefab, ShotSpawn.position, ShotSpawn.rotation) as GameObject;
		}
	}
}
