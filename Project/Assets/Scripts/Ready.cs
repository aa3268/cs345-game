﻿using UnityEngine;
using System.Collections;

public class Ready : MonoBehaviour {
	public ParticleSystem one;
	public ParticleSystem two;
	public ParticleSystem three;
	public ParticleSystem four;

	public GameObject level;
	public GameObject timer;
	public bool clicked;
	void Start()
	{
		clicked = false;
		one.enableEmission = false;
		two.enableEmission = false;
		three.enableEmission = false;
		four.enableEmission = false;

		//level.SetActive (false);
	}

	public void IsReady () {
		Time.timeScale = 1;
		one.enableEmission = true;
		two.enableEmission = true;
		three.enableEmission = true;
		four.enableEmission = true;
		
		//level.SetActive (true);
		if (!clicked) {
			Instantiate (timer);
		}

		clicked = true;
		//Destroy (transform.parent.gameObject);
	}
}
