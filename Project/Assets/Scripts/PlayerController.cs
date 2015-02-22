using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {


	public float rotationSpeed = 80f;

	private float rotateValue = 0f;

	protected Vector3 move =  Vector3.zero;




	// Update is called once per frame

	void Start()
	{

	}
	void Update () {

		rotateValue -= Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
		rotateValue = Mathf.Clamp (rotateValue, -30, 30);
		transform.localEulerAngles = new Vector3 (0f, 0f,rotateValue);


	}
}
