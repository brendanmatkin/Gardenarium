using UnityEngine;
using System.Collections;

public class cameraDolly : MonoBehaviour {
	public Transform start_pos;
	public Transform end_pos;
	public Transform target;
	public float speed = 1.0f;
    private bool up = false;


	void Update(){

		if (Input.GetKeyDown(KeyCode.C)) {
			up = !up;
		}

		if (up) {
			Transform _start_pos = target;
			Transform _end_pos = end_pos;
			//transform.position = Vector3.Lerp(_start_pos.position, _end_pos.position, fracJourney);
			transform.position = Vector3.Lerp(_start_pos.position, _end_pos.position, Time.deltaTime * speed);
			transform.rotation = Quaternion.Slerp(_start_pos.rotation, _end_pos.rotation, Time.deltaTime * speed);
		}
		if (!up) {
			Transform _start_pos = target;
			Transform _end_pos = start_pos;
			transform.position = Vector3.Lerp(_start_pos.position, _end_pos.position, Time.deltaTime * speed);
			transform.rotation = Quaternion.Slerp(_start_pos.rotation, _end_pos.rotation, Time.deltaTime * speed);
		} 
			//transform.rotation = Quaternion.Slerp(start_rot.rotation, end_rot.rotation, zoom);
	}

}