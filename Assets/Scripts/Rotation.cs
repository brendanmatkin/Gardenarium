using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	
	public float myRotationSpeed = 100.0f;
	
	public bool isRotateX = false;
	public bool isRotateY = false;
	public bool isRotateZ = false;
	
	// CHANGE TO ROTATE IN OPPOSITE DIRECTION
	private bool positiveRotation = false;
	
	private int posOrNeg = 1;
	
	// Use this for initialization
	void Start ()
	{
		collider.isTrigger = true;
		if(positiveRotation == false)
		{
			posOrNeg = -1;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		//  Toggles X Rotation
		if(isRotateX)
		{
			transform.Rotate(myRotationSpeed * Time.deltaTime * posOrNeg, 0, 0);//rotates coin on X axis
			//Debug.Log("You are rotating on the X axis");    
		}
		//  Toggles Y Rotation
		if(isRotateY)
		{
			transform.Rotate(0, myRotationSpeed * Time.deltaTime * posOrNeg, 0);//rotates coin on Y axis
			//Debug.Log("You are rotating on the Y axis");
		}
		//  Toggles Z Rotation
		if(isRotateZ)
		{
			transform.Rotate(0, 0, myRotationSpeed * Time.deltaTime * posOrNeg);//rotates coin on Z axis
			//Debug.Log("You are rotating on the Z axis");
		}
		
	}
	
}
