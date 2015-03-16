using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Info : MonoBehaviour {
	public Text range;
	public Text baseScore;
	public Text time;
	public new string name;
	public GameObject level;
	// Use this for initialization
	void Start () {
		level = GameObject.FindGameObjectWithTag ("Level");
		name = level.name;
		range = transform.FindChild("rangeGiven").GetComponent<Text>();
		baseScore = transform.FindChild("scoreGiven").GetComponent<Text>();
		time = transform.FindChild("timeGiven").GetComponent<Text>();

		switch (name) 
		{
		case "Level1":

			range.text = "[2-4]";
			baseScore.text = "500";
			time.text = "20";
		break;
		case "Level2":
			range.text = "[5-7]";
			baseScore.text = "500";
			time.text = "30";
			break;
		case "Level3":
			range.text = "[1-3]";
			baseScore.text = "500";
			time.text = "30";
			break;
		case "Level4":
			range.text = "[2-4]";
			baseScore.text = "500";
			time.text = "35";
			break;
		case "Level5":
			range.text = "[3-5]";
			baseScore.text = "500";
			time.text = "45";
			break;
		case "Level6":
			range.text = "[1-3]";
			baseScore.text = "500";
			time.text = "60";
			break;
		case "Level7":
			range.text = "[1-3]";
			baseScore.text = "500";
			time.text = "90";
			break;
		case "Level8":
			range.text = "[3-5]";
			baseScore.text = "500";
			time.text = "100";
			break;
		case "Level9":
			range.text = "[4-6]";
			baseScore.text = "500";
			time.text = "75";
			break;
		case "Level10":
			range.text = "[2-4]";
			baseScore.text = "500";
			time.text = "60";
			break;
		case "Level11":
			range.text = "[3-5]";
			baseScore.text = "500";
			time.text = "70";
			break;
		case "Level12":
			range.text = "[3-5]";
			baseScore.text = "500";
			time.text = "120";
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
