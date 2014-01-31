using UnityEngine;
using System.Collections;

public class dungeonCamera : MonoBehaviour {
	public GameObject target;
	public float damping = 1;
	Vector3 offset;

	void Start(){
		offset = transform.position - target.transform.position;
	}
	void LateUpdate(){
		Vector3 desiredPosition = target.transform.position + offset;
		Vector3 position = Vector3.Lerp(transform.position,desiredPosition,Time.deltaTime *damping);
		transform.position = desiredPosition;
		transform.LookAt (target.transform.position);
	}
}
