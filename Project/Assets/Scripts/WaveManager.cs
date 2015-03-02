using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour {
	public int waveCount;
	public GameObject[] waves;
	public GameObject wave1;
	public GameObject wave2;
	public GameObject wave3;

	public int count;
	public int nextLevel;
	public bool get = false;

	// Use this for initialization
	void Start()
	{
		nextLevel = 1;
		waves = new GameObject[waveCount];
		waves [0] = wave1;
		waves [1] = wave2;
		waves [2] = wave3;
		Instantiate (waves [0], new Vector3 (-7.6f, 50f, 66f), waves [0].transform.localRotation);
	}

	// Update is called once per frame
	void Update () {
		count = GameObject.FindGameObjectsWithTag ("Asteroids").Length;
		if (count == 0 && nextLevel < waveCount && get == false)
		{
			get = true;
			Destroy(GameObject.FindGameObjectWithTag("Level").gameObject);
			Invoke("getWave", 5);
			nextLevel++;
			get = false;
		}

		
	
	}
	
	void getWave()
	{
		Instantiate (waves [nextLevel], waves[nextLevel].transform.localPosition, waves [nextLevel].transform.localRotation);	
	}
}
