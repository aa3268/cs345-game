using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ToMain : MonoBehaviour {

	public Text text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			Application.LoadLevel(1);
		}

	}
}
