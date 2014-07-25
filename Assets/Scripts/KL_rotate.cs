using UnityEngine;
using System.Collections;

public class KL_rotate : MonoBehaviour {
	public float continuousRotationSpeed = 10;	
	public float absoluteRotationFactor = 720;
	public float timeFactor = 5;
	public bool continuous = true;

	void Update () {
		if (continuous) {
			transform.Rotate(0, Input.GetAxis("Mouse ScrollWheel") * continuousRotationSpeed, 0, Space.World); //This is where you rotate your GameObject
		}
		else {
			float tiltY = Input.GetAxis("Mouse ScrollWheel") * absoluteRotationFactor;
			Quaternion target = Quaternion.Euler(0,tiltY,0);
			transform.rotation = Quaternion.Slerp(transform.rotation,target, Time.deltaTime * timeFactor);
		}
	}    	
}