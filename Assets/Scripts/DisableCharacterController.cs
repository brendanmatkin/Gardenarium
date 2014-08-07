using UnityEngine;
using System.Collections;

public class DisableCharacterController : MonoBehaviour
{
	private CharacterController charctrl;
	
	
	void Start ()
	{
		charctrl = GetComponent<CharacterController>();
	}
	
	
	void Update ()
	{
		if (Input.GetButtonDown("Camera")) 
		{
			charctrl.enabled = !charctrl.enabled;
		}
	}
}