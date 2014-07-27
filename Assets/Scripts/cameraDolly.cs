using UnityEngine;
using System.Collections;

public class cameraDolly : MonoBehaviour {
	public AnimationCurve rotCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
	public AnimationCurve distYCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
	public AnimationCurve distZCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
	public Transform startPos;
	public Transform endPos;
	public Transform target;
	public float speed = 1.0f;
	public float inc = 0.005f;
    private bool up = false;
    private float zoom = 0.0f;


	void Update(){

		if (Input.GetKeyDown(KeyCode.C)) {
			up = !up;
			//zoom = 0.0f;
			//else zoom = 1.0f;
		}
		//print(zoom);

		/*if (!up) {
			Transform _startPos = target;
			Transform _endPos = startPos;
			transform.position = Vector3.Lerp(_startPos.position, _endPos.position, Time.deltaTime * speed);
			transform.rotation = Quaternion.Slerp(_startPos.rotation, _endPos.rotation, Time.deltaTime * speed);
		} */

		Transform _startPos = target;
		Transform _endPos = endPos;
		//float zoom = target.position.y/_endPos.position.y;
		if (up) {
			if (zoom < (1.0f-inc)) zoom += inc;		
		}
		else {
			if (zoom > (0.0f+inc)) zoom -= inc;
			if (zoom < inc) zoom = 0.0f;
		}
		float targetRotX = rotCurve.Evaluate(zoom);	

		Vector3 offset = new Vector3(_endPos.position.x, distYCurve.Evaluate(zoom)*_endPos.position.y, _endPos.position.z);
		//if (zoom < 0.1) transform.position = Vector3.Lerp
		Vector3 transformOffset = new Vector3(transform.position.x, transform.position.y, transform.position.z-(distZCurve.Evaluate(zoom)*speed));
		transform.position = Vector3.Lerp(transformOffset, offset, zoom+(inc*10));
		//transform.position = offset;
			
		Quaternion xRotation = Quaternion.Euler(targetRotX*90,target.rotation.eulerAngles.y,0.0f);
		transform.rotation = Quaternion.Slerp(transform.rotation, xRotation, zoom+(inc*10));
		//transform.rotation = xRotation;

	}

}