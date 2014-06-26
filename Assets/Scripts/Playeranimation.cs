using UnityEngine;
using System.Collections;

public class Playeranimation : MonoBehaviour {
	public Animator anim; 
	
	void Start () {
				anim = GetComponent<Animator> ();
		}
	void Update ()
	{
		if (Input.GetKey (KeyCode.W)) {
			anim.SetBool ("upkeyw", true);
				}
		else {
			anim.SetBool ("upkeyw", false);

			anim.SetBool ("downkeys", false); 	
			anim.SetBool ("leftkeyA", false);
			anim.SetBool ("rightkeyd", false);
			anim.SetBool ("forwardkeye", false); 
			anim.SetBool ("backkeyq", false); 

	
		}
		if (Input.GetKey (KeyCode.E)) {
			anim.SetBool ("forwardkeye", true); 

			anim.SetBool ("rightkeyd", false);
			anim.SetBool ("downkeys", false); 
			anim.SetBool ("leftkeyA", false);
			anim.SetBool ("upkeyw", false);
			anim.SetBool ("backkeyq", false); 


		}
		if (Input.GetKey (KeyCode.Q)) {
			anim.SetBool ("backkeyq", true); 

			anim.SetBool ("forwardkeye", false); 
			anim.SetBool ("rightkeyd", false);
			anim.SetBool ("downkeys", false); 
			anim.SetBool ("leftkeyA", false);
			anim.SetBool ("upkeyw", false);
			
		}
		if (Input.GetKey (KeyCode.S)) {
			anim.SetBool ("downkeys", true); 
			
			
			anim.SetBool ("upkeyw", false);
			anim.SetBool ("leftkeyA", false);
			anim.SetBool ("rightkeyd", false);
			anim.SetBool ("forwardkeye", false); 
			anim.SetBool ("backkeyq", false); 
		}
		if (Input.GetKey (KeyCode.D)) {
			anim.SetBool ("rightkeyd", true);
			
			
			anim.SetBool ("upkeyw", false);
			anim.SetBool ("leftkeyA", false);
			anim.SetBool ("downkeys", false); 
			anim.SetBool ("forwardkeye", false); 
			anim.SetBool ("backkeyq", false); 
		}
		if (Input.GetKey (KeyCode.A)) {
			anim.SetBool ("leftkeyA", true);
			
			anim.SetBool ("upkeyw", false);
			anim.SetBool ("downkeys", false); 
			anim.SetBool ("rightkeyd", false);
			anim.SetBool ("forwardkeye", false); 
			anim.SetBool ("backkeyq", false); 
			

		
		}
	}
}
