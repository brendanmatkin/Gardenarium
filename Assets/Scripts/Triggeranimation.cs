using UnityEngine;
using System.Collections;

public class Triggeranimation : MonoBehaviour {
	public Animator anim; 
	
	void Start () {
		anim = GetComponent<Animator> ();
	}
	void Update ()
	{
		if (Input.GetButtonDown("Camera")) {
			anim.SetBool ("TriggerC", true);
				}
				else {
				anim.SetBool ("TriggerC", false);
			
		}
	}
}
