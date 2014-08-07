using UnityEngine;
using System.Collections;

public class SimpleRotate : MonoBehaviour
{
	public float turnSpeed = 50f;
	
	
	void Update ()
	{	
		float spinner = Input.GetAxis ("Spin");
		/*if(Input.GetAxis("Spin")
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);*/
		transform.Rotate (Vector3.up, turnSpeed * spinner);
	}
}