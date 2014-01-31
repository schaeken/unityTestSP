using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float movementSpeed = 10;
	public float turningSpeed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Vertical") * turningSpeed * Time.deltaTime;
		transform.Rotate (0, horizontal, 0);
		float vertical = Input.GetAxis ("Horizontal") * movementSpeed * Time.deltaTime;
		transform.Translate (vertical,0 ,0);

	}
}
