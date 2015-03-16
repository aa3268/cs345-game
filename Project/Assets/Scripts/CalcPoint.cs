using UnityEngine;
using System.Collections;


public class CalcPoint : MonoBehaviour {

	public GameObject[] t;
	public int size;

	public GUIText finalScore;
	public GUIText timeLeft;
	public GUIText baseScore;
	public GUIText totalScore;

	public GUIText rangeText;
	public GUIText shotText;

	public int shotCount;
	public int range;
	public int itime;
	public int ibaseScore;
	public int ifinalScore;
	public int itotalScore;

	new string name;

	public GameObject player;

	bool calced;
	// Use this for initialization
	void Start () {
		calced = false;
		t = GameObject.FindGameObjectsWithTag ("Asteroids");
		size = t.Length;
		shotCount = 0;

		name = GameObject.FindGameObjectWithTag ("Level").gameObject.name;
		switch(name)
		{
			case "Level1":
			range = 5;
			break;
			case "Level2":
			range = 5;
			break;
			case "Level3":
			range = 7;
			break;
		}

	}
	// Update is called once per frame
	void Update () {
		t = GameObject.FindGameObjectsWithTag ("Asteroids");
		size = t.Length;

		ShootBullet count = player.GetComponent<ShootBullet>();
		shotCount = count.counter;
		
		if (size == 0 && calced == false)
		{	
			Calc ();

		}
	}
	void Calc()
	{
		if (!calced) {
			int.TryParse (timeLeft.text, out itime);
			int.TryParse (baseScore.text, out ibaseScore);
			int.TryParse (totalScore.text, out itotalScore);

			if (shotCount <= range) {
					ifinalScore = (10 * ibaseScore) + (itime * 10);
					if (ifinalScore % 10 == 9) {
							ifinalScore += 1;
					}
					itotalScore = itotalScore + ifinalScore;
					finalScore.text = ifinalScore.ToString ();
					totalScore.text = itotalScore.ToString ();

			} else {
				if ((1 - 0.1 * (shotCount - range)) >= 0.1) {
						ifinalScore = (int)((1 - 0.1 * (shotCount - range)) * ibaseScore) + (itime * 10);
						if (ifinalScore % 10 == 9) {
								ifinalScore += 1;
						}
						itotalScore = itotalScore + ifinalScore;
						finalScore.text = ifinalScore.ToString ();
						totalScore.text = itotalScore.ToString ();
				} else {
						ifinalScore = (int)((0.1 * ibaseScore) + (itime * 10));
						if (ifinalScore % 10 == 9) {
								ifinalScore += 1;
						}
						itotalScore = itotalScore + ifinalScore;
						finalScore.text = ifinalScore.ToString ();
						totalScore.text = itotalScore.ToString ();
				}
			}
			if (Application.loadedLevel != 7) {
				wait();
				Application.LoadLevel (Application.loadedLevel + 1);
			}
			calced = true;
		}
	

	}
	IEnumerator wait()
	{
		yield return new WaitForSeconds (3f);
	}
}
