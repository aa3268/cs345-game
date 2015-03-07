using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Info : MonoBehaviour {
	public Text range;
	public Text baseScore;
	public Text time;
	public string name;
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

			range.text = "[5-7]";
			baseScore.text = "500";
			time.text = "40";
		break;
		case "Level2":
			range.text = "[5-7]";
			baseScore.text = "500";
			time.text = "40";
			break;
		case "Level3":
			range.text = "[5-7]";
			baseScore.text = "500";
			time.text = "40";
			break;
		case "Level4":
			range.text = "[5-7]";
			baseScore.text = "500";
			time.text = "40";
			break;
		case "Level5":
			range.text = "[5-7]";
			baseScore.text = "500";
			time.text = "40";
			break;
		case "Level6":
			range.text = "[5-7]";
			baseScore.text = "500";
			time.text = "40";
			break;
		
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
