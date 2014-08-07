using UnityEngine;
using System.Collections;

/// MouseLook rotates the transform based on the mouse delta.
/// Minimum and Maximum values can be used to constrain the possible rotation

/// To make an FPS style character:
/// - Create a capsule.
/// - Add the MouseLook script to the capsule.
///   -> Set the mouse look to use LookX. (You want to only turn character but not tilt it)
/// - Add FPSInputController script to the capsule
///   -> A CharacterMotor and a CharacterController component will be automatically added.

/// - Create a camera. Make the camera a child of the capsule. Reset it's transform.
/// - Add a MouseLook script to the camera.
///   -> Set the mouse look to use LookY. (You want the camera to tilt up and down like a head. The character already turns.)
[AddComponentMenu("Camera-Control/Mouse Look")]
public class MouseLookCameraDolly : MonoBehaviour {

	public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	public bool lerp = true;
	public RotationAxes axes = RotationAxes.MouseXAndY;
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;

	public float minimumX = -360F;
	public float maximumX = 360F;

	public float minimumY = -60F;
	public float maximumY = 60F;
	//private bool cameraDolly = CameraDolly.topView; 

	float rotationY = 0F;
	Vector3 mouseRotation = new Vector3(0,0,0);

	void Update ()
	{
		CameraDolly cameraDolly = GetComponent<CameraDolly>();
		bool control = cameraDolly.topView;
		if (control == false) {
			//print ("Control off!");
			if (axes == RotationAxes.MouseXAndY)
			{
				float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
				
				rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
				rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
				
				transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
			}
			else if (axes == RotationAxes.MouseX)
			{
				transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
			}
			else
			{
				rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
				rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
				//transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);

				mouseRotation = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
				transform.localEulerAngles = mouseRotation;

				
			}
		}
		if (cameraDolly.mouser == true && cameraDolly.zoom <= 0.0f) {
			print("YUP!");
					// this bit stops the camera from jumping when mouse control is returned - it solves the problem but is not behaving as expected. 
					//Vector3.Lerp( transform.rotation, mouseRotation, Time.deltaTime);
					mouseRotation = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
					//transform.rotation.x = Mathf.Lerp(transform.rotation.x, -rotationY, cameraDolly.counter);
					float rotX = Mathf.Lerp(transform.rotation.eulerAngles.x, mouseRotation.x, cameraDolly.counter);
					transform.rotation = Quaternion.Euler(rotX,transform.rotation.eulerAngles.y,0);
		}
	}
	
	void Start ()
	{
		// Make the rigid body not change rotation
		if (rigidbody)
			rigidbody.freezeRotation = true;
	}
}