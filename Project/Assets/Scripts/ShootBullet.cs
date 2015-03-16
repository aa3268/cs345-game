using UnityEngine;
using System.Collections;


public class ShootBullet : MonoBehaviour {



	public float cooldown = 0.2f;
	float cooldownRemaining = 0;

	public GameObject projectilePrefab;

	public Transform ShotSpawn;

	public int counter = 0;

	// Update is called once per frame
	void Update () {
	
		cooldownRemaining -= Time.deltaTime;
		if (GameObject.Find ("Starter").transform.position.y < -399 && GameObject.Find ("LevelComplete").transform.position.y > 599) {
			if (Input.GetKeyDown (KeyCode.Space) && cooldownRemaining <= 0) {
					counter++;
					cooldownRemaining = cooldown;
					GameObject clode = Instantiate (projectilePrefab, ShotSpawn.position, ShotSpawn.rotation) as GameObject;
			}
		}
	}












}
