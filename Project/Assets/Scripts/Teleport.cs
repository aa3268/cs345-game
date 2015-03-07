using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public GameObject projectilePrefab;
	public GameObject exitCrystal;
	public ParticleSystem enter;
	public ParticleSystem exit;

	public Transform ShotSpawn;

	bool emitExit;
	void Start()
	{
		emitExit = false;
		exit = exitCrystal.GetComponent<ParticleSystem> ();
	}
	// Update is called once per frame
	void OnCollisionEnter (Collision col) 
	{
		enter.Emit (10);
		Invoke ("tp", 1f);

	}

	void tp()
	{
		exit.Emit (20);
		GameObject clone = Instantiate (projectilePrefab, ShotSpawn.position, ShotSpawn.rotation) as GameObject;
		Invoke ("blowUp", 1f);
	}

	void blowUp()
	{
		Destroy (gameObject.transform.parent.gameObject);
	}
}

