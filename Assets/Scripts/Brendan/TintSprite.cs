// Brendan Matkin 
// http://brendanmatkin.info
// brendan@brendanmatkin.info

using UnityEngine;
using System.Collections;

public class TintSprite : MonoBehaviour
{
	public bool continuousUpdate = true;
	public Color tintColor = new Color(0.0f,0.5f,1.0f,0.9f);

	void Awake(){
		transform.renderer.material.color = tintColor;
	}

	void Update(){
		if (continuousUpdate == true){
			transform.renderer.material.color = tintColor;	
		}
	}
}