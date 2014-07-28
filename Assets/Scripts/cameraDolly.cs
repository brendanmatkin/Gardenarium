using UnityEngine;
using System.Collections;

public class CameraDolly : MonoBehaviour {
	public AnimationCurve rotCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
	public AnimationCurve distYCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
	public AnimationCurve distZCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
	public Transform startPos;
	public Transform endPos;
	public Transform target;
	//public float speed = 1.0f;
	public float inc = 0.005f;
	public float mouseDelay = 1.0f;
    private bool up = false;
    [HideInInspector]
    public bool topView = false;
    [HideInInspector]
    public float targetRotX;
    [HideInInspector]
    public float zoom = 0.0f;
    [HideInInspector]
    public float counter = 0;

    void Start() {
    	camera.orthographicSize = 200;
    }


	void Update(){

		if (Input.GetKeyDown(KeyCode.C)) {
			up = !up;
			topView = true;
			if (topView) target.rotation = Quaternion.Euler(target.rotation.eulerAngles.x+(inc*2),target.rotation.eulerAngles.y,target.rotation.eulerAngles.z);
		}
		//print(zoom);

		/*if (!up) {
			Transform _startPos = target;
			Transform _endPos = startPos;
			transform.position = Vector3.Lerp(_startPos.position, _endPos.position, Time.deltaTime * speed);
			transform.rotation = Quaternion.Slerp(_startPos.rotation, _endPos.rotation, Time.deltaTime * speed);
		} */
		if (topView) {
			Transform _startPos = startPos;
			Transform _endPos = endPos;
			//float zoom = target.position.y/_endPos.position.y;
			if (up) {
				if (zoom < (1.0f-inc)) zoom += inc;		
			}
			else {
				if (zoom > (0.0f+inc)) zoom -= inc;
				if (zoom < inc) zoom = 0.0f;
			}
			print(zoom);
			targetRotX = rotCurve.Evaluate(zoom);	

			Vector3 offset = new Vector3(_endPos.position.x, distYCurve.Evaluate(zoom)*_endPos.position.y, _endPos.position.z-distZCurve.Evaluate(zoom));
			Vector3 transformOffset = new Vector3(_startPos.position.x, _startPos.position.y, _startPos.position.z);
			transform.position = Vector3.Lerp(transformOffset, offset, zoom);
			//transform.position = offset;
				
			Quaternion xRotation = Quaternion.Euler(targetRotX*90,target.rotation.eulerAngles.y,0.0f);
			transform.rotation = Quaternion.Slerp(transform.rotation, xRotation, zoom+(inc*10));		
			//transform.rotation = xRotation;

			//if (target.rotation.eulerAngles.x < inc && target.rotation.eulerAngles.x != 0) transform.rotation = Quaternion.Euler(0.0f,target.rotation.eulerAngles.y,target.rotation.eulerAngles.z);
			//else transform.rotation = Quaternion.Slerp(transform.rotation, xRotation, zoom+(inc*10));
			if (zoom >= 1.0f-inc) camera.orthographic = true;
			else camera.orthographic = false; 
			
			if (zoom <= 0.0f) {
				counter += Time.deltaTime;
				//print("time on 0 zoom");
				//print(counter);
				if (counter > mouseDelay){
					topView = false;
					counter = 0;
				}
			}
		}
		else {
			//targetRotX = 0.0f;
		}
	}

}