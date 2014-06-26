using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed;	

	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			rigidbody.AddForce(Vector2.up * speed);
		}
		if (Input.GetKey (KeyCode.A)) {
			rigidbody.AddForce(-Vector2.right * speed);  
		}
		if (Input.GetKey (KeyCode.S)) {
			rigidbody.AddForce(-Vector2.up * speed);
		}
		if (Input.GetKey (KeyCode.D)) {
			rigidbody.AddForce(Vector2.right * speed);
		}
		if (Input.GetKey (KeyCode.E)) {
			rigidbody.AddForce(Vector3.forward * speed);
		}
		if (Input.GetKey (KeyCode.Q)) {
			rigidbody.AddForce(-Vector3.forward * speed);
		}
	}
}
