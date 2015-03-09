using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Timer2 : MonoBehaviour {

	Text value;
	public float timer;
	public int count;
	void Start () {
		value = GetComponent<Text>();
	}
	void Update()
	{
		if (GameObject.FindGameObjectWithTag ("Level").transform.position.y <= 5) 
		{
			timer -= Time.deltaTime;
			count = (int)timer;
			value.text = count.ToString ();
			if(count == 0)
			{
				Application.LoadLevel(0);
			}
		}
	}
}
