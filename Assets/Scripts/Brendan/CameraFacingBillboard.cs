// http://wiki.unity3d.com/index.php?title=CameraFacingBillboard

//cameraFacingBillboard.cs v03
//by Neil Carter (NCarter)
//modified by Juan Castaneda (juanelo)
//modified by Brendan Matkin
//
//added in-between GRP object to perform rotations on
//added auto-find main camera
//added un-initialized state, where script will do nothing
//BM - added color tinting
using UnityEngine;
using System.Collections;


public class CameraFacingBillboard : MonoBehaviour
{
	
	public Camera m_Camera;
	public bool amActive =false;
	public bool autoInit =true;
	//public bool _32bitColor = true;
	//public Color32 tintColor = new Color32(127,0,255,255);
	//public Color tintColor = new Color(0.0F,0.5F,1.0F,1.0F);
	GameObject myContainer;	
	
	void Awake(){
		if (autoInit == true){
			m_Camera = Camera.main;
			amActive = true;
		}
		// switch to 32 bit color necessary for analog input??
		//if (_32bitColor == false) {
		//	tintColor = new Color(0.5F,0.0F,1.0F,1.0F);
		//}
		
		myContainer = new GameObject();
		myContainer.name = "GRP_"+transform.gameObject.name;
		myContainer.transform.position = transform.position;
		transform.parent = myContainer.transform;
		//transform.renderer.material.color = tintColor;
	}
	
	
	void Update(){
		if(amActive==true){
			myContainer.transform.LookAt(myContainer.transform.position + m_Camera.transform.rotation * Vector3.back, m_Camera.transform.rotation * Vector3.up);
		}
	}
}
