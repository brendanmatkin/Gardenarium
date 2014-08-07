using UnityEngine;
using System.Collections;

public class DisableMouseLookScript : MonoBehaviour
{
	private MouseLook lookscript;
	
	
	void Start ()
	{
		lookscript = GetComponent<MouseLook>();
	}
	
	
	void Update ()
	{
		if (Input.GetButtonDown("Camera")) 
		{
			lookscript.enabled = !lookscript.enabled;
		}
	
	}
}