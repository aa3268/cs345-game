using UnityEngine;
using System.Collections;

public class CalcPoint : MonoBehaviour {

	public GameObject[] t;
	public int size;
	public GUIText finalScore;
	public GUIText timeLeft;
	public GUIText baseScore;

	public double shotCount;
	public int itime;
	public int ibaseScore;
	public float ifinalScore;

	public float cooldown = 0.2f;
	float cooldownRemaining = 0;

	// Use this for initialization
	void Start () {
		t = GameObject.FindGameObjectsWithTag ("Asteroids");
		size = t.Length;
		shotCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		t = GameObject.FindGameObjectsWithTag ("Asteroids");
		size = t.Length;

		cooldownRemaining -= Time.deltaTime;

		if (Input.GetKey (KeyCode.Space) && cooldownRemaining <= 0 && Time.timeScale != 0)
		{
			cooldownRemaining = cooldown;
			shotCount++;
		}
		if (size == 0)
		{
			Time.timeScale = 0;

			int.TryParse(timeLeft.text, out itime);
			int.TryParse(baseScore.text, out ibaseScore);

			if(shotCount == 2)
			{
				ifinalScore = (10 * ibaseScore) + (itime * 10);
				finalScore.text = ifinalScore.ToString();

			}
			else
			{
				if((1 - 0.1 * shotCount) >= 0.1)
				{
					ifinalScore = (int)((1 - 0.1 * shotCount) * ibaseScore) + (itime * 10);
					finalScore.text = ifinalScore.ToString();
				}
				else
				{
					ifinalScore = (int)((0.1 * shotCount) * ibaseScore) + (itime * 10);
					finalScore.text = ifinalScore.ToString();
				}
			}

		}
	}
}
