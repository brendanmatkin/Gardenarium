using UnityEngine;
using System.Collections;

public class KL_rotate : MonoBehaviour {
	public float continuousRotationSpeed;	
	public float absoluteRotationFactor;
	public float timeFactor;
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