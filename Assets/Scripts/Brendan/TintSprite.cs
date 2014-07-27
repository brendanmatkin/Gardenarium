// Brendan Matkin 
// http://brendanmatkin.info
// brendan@brendanmatkin.info

using UnityEngine;
using System.Collections;



public class TintSprite : MonoBehaviour
{
	public bool continuousUpdate = true;
	public static Color tintColor = new Color(0.0f,0.5f,1.0f,1.0f);
	public static string _tC = "waiting...";
	

	void Awake(){
		
		//foreach (Transform child in transform) {
        //    child.transform.renderer.material.color = tintColor;
        //}
		//transform.renderer.material.color = tintColor;
	}
	void Tint(Color tC){
		tintColor = tC;
		_tC = tC.ToString();
		//print(_tC);
	}
	void Update(){	
		if (continuousUpdate == true){
			renderer.material.color = tintColor;
		}
		//print(tintColor);
	}
	
}