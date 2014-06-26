using UnityEngine;
using System.Collections;

public class CollideWithObjects : MonoBehaviour {

	public float particlesDuration = 3f;
	public GameObject particlesObject;

	float timer;
	bool timerOn = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timerOn == true) {
			timer += Time.deltaTime;
			if (timer > particlesDuration){
				particlesObject.particleSystem.enableEmission = false;
				timerOn = false;
				timer = 0;
			}
		}
	}

	void OnTriggerEnter(Collider other){
		particlesObject.particleSystem.enableEmission = true;
		timerOn = true;
	}
}
