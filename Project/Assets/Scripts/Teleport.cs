using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public GameObject projectilePrefab;
	public GameObject exitCrystal;
	public GameObject explosion;
	public ParticleSystem enter;
	public ParticleSystem exit;

	public Transform ShotSpawn;
	
	void Start()
	{
		exit = exitCrystal.GetComponent<ParticleSystem> ();
	}
	// Update is called once per frame
	void OnCollisionEnter (Collision col) 
	{
		enter.Emit (40);
		Invoke ("tp", 1f);

	}

	void tp()
	{
		exit.Emit (40);
		GameObject clone = Instantiate (projectilePrefab, ShotSpawn.position, ShotSpawn.rotation) as GameObject;
		Invoke ("blowUp", 0.55f);
	}

	void blowUp()
	{
		Instantiate (explosion, gameObject.transform.parent.position, gameObject.transform.parent.rotation);
		Invoke ("DestroyAst", 0f);
	}

	void DestroyAst()
	{
		Destroy (gameObject.transform.parent.gameObject);
	}
}

