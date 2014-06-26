using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {
	void Update() {
		if (Input.GetKey("escape"))
			Application.Quit();
		
	}
}