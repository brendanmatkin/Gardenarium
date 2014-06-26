using UnityEngine;
using System.Collections;

public class ScrollScript: MonoBehaviour 
{

	public float speed = 2;
	
	void Update () 
	{
		renderer.material.mainTextureOffset = new Vector2(Time.time * speed, -0.01f); 
	}
}