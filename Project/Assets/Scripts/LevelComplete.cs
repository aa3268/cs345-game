using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour {

	public Text timeText;
	public Text shotText;
	public Text scoreText;
	public Text buttonText;

	public GameObject[] asteroids;


	public new string name;
	public string time;

	public GUIText timer;
	public GameObject level;
	public GameObject player;
	public ShootBullet counter;

	public int rangeMin;
	public int rangeMax;
	public int baseScore;
	public int finalScore;
	public int size;

	public int count;
	public int timeLeft;

	public bool calced;
	// Use this for initialization
	void Start () {
		calced = false;
		asteroids = GameObject.FindGameObjectsWithTag ("Asteroids");
		level = GameObject.FindGameObjectWithTag ("Level");
		name = level.name;

		switch (name) 
		{
		case "Level1":		
			rangeMin = 2;
			rangeMax = 4;
			baseScore = 500;
			break;
		case "Level2":
			rangeMin = 5;
			rangeMax = 7;
			baseScore = 500;
			break;
		case "Level3":
			rangeMin = 1;
			rangeMax = 3;
			baseScore = 500;
			break;
		case "Level4":
			rangeMin = 2;
			rangeMax = 4;
			baseScore = 500;
			break;
		case "Level5":
			rangeMin = 1;
			rangeMax = 3;
			baseScore = 500;
			break;
		case "Level6":
			rangeMin = 1;
			rangeMax = 3;
			baseScore = 500;
			break;
		case "Level7":
			rangeMin = 1;
			rangeMax = 3;
			baseScore = 500;
			break;
		case "Level8":
			rangeMin = 3;
			rangeMax = 5;
			baseScore = 500;
			break;
		case "Level9":
			rangeMin = 4;
			rangeMax = 6;
			baseScore = 500;
			break;
		case "Level10":
			rangeMin = 2;
			rangeMax = 4;
			baseScore = 500;
			break;
		case "Level11":
			rangeMin = 3;
			rangeMax = 5;
			baseScore = 500;

			break;
		case "Level12":
			rangeMin = 3;
			rangeMax = 5;
			baseScore = 500;

			break;
			
		}
	}

	// Update is called once per frame
	void Update () {

		asteroids = GameObject.FindGameObjectsWithTag ("Asteroids");
		timer = GameObject.Find ("Timer(Clone)").guiText;
		time = timer.text;
		if (time == "00")
		{
			timeText.text = "00";
			counter = player.GetComponent<ShootBullet>();
			count = counter.counter;
			shotText.text = count.ToString();
			scoreText.text = "00";

		}
		size = asteroids.Length;
		if (size == 0 && !calced)
		{
			Calc ();
		}

	}

	void Calc()
	{
		counter = player.GetComponent<ShootBullet>();
		timer = GameObject.Find ("Timer(Clone)").guiText;
		count = counter.counter;
		time = timer.text;
		
		if (time [0].ToString() == "0") {
			int.TryParse (time [1].ToString(), out timeLeft);
		} 
		else {
			int.TryParse (time, out timeLeft);
		}



		if (count == rangeMin) 
		{
			finalScore = (10 * baseScore) + (timeLeft * 10);
			if (finalScore % 10 == 9) {
					finalScore += 1;
			}
			
		} 
		else if (count == rangeMin + 1) 
		{
			finalScore = (5 * baseScore) + (timeLeft * 10);
			if (finalScore % 10 == 9) {
					finalScore += 1;
			}
		} 
		else if (count == rangeMax)
		{
			finalScore = (2 * baseScore) + (timeLeft * 10);
			if (finalScore % 10 == 9) {
				finalScore += 1;
			}

		}
		else{
			if ((1 - 0.1 * (count - rangeMax)) >= 0.1) {
				finalScore = (int)((1 - 0.1 * (count - rangeMax)) * baseScore) + (timeLeft * 10);
				if (finalScore % 10 == 9) {
					finalScore += 1;
				}
			}
			else {
				finalScore = (int)((0.1 * baseScore) + (timeLeft * 10));
				if (finalScore % 10 == 9) {
					finalScore += 1;
				}
			}
		}
		timeText.text = timeLeft.ToString ();
		scoreText.text = finalScore.ToString ();
		shotText.text = count.ToString ();


		calced = true;
	}

	public void NextLevel()
	{
		if (Application.loadedLevel != 14)
		{
			Application.LoadLevel (Application.loadedLevel + 1);
		} 
		else 
		{
			Application.LoadLevel (0);
		}
	}
	
}
