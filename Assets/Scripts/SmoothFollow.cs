using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour {

	public GameObject targetObject;
	public float followSpeed = 1; //I picked 1 as the default speed, but you can change this in the Inspector. -Matt

	// Use this for initialization
	void Start () {
		//nothing here for now
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, targetObject.transform.position, followSpeed * Time.deltaTime);
	}
	//A QUICK EXPLANATION:
	//void Update means we want to do this action every single game update frame.
	//Vector3.Lerp is a function to find a point in between two Vector3 points--we want to find a new location to move to, in between 2 other locations.
	//We have to give the Lerp function 3 parameters--the things inside the parentheses. The 3 things are: Starting point, destination point, and how much we want to move.
	//gameObject.transform.position is our current position, so we'll say that's our starting point,
	//targetObject.transform.position is where we want to end up,
	//and followSpeed * Time.deltaTime is how far we want to move from point A towards point B in this current frame. 
	//Every single game update frame, we want to move by a factor of our followSpeed multiplied by Time.deltaTime (which is a magic Unity phrase meaning the time since the last update frame)
	// -Matt
}
