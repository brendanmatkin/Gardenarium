using UnityEngine;
using System.Collections;

public class KL_rotate : MonoBehaviour {
	//public float speed;
	public float rotation;	

	void Update () {
		//if (Input.GetKey (KeyCode.K)) {
		//	rigidbody.AddForce(-Vector2.right * speed);  
		//}
		//if (Input.GetKey (KeyCode.L)) {
		//	rigidbody.AddForce(Vector2.right * speed);
		//}
		transform.Rotate(Input.GetAxis("Mouse ScrollWheel") * rotation * Time.deltaTime, 0, 0, Space.World); //This is where you rotate your GameObject
	}

    	
}