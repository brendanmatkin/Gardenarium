using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;

	private Transform myTransform;

	void Awake(){
				myTransform = transform;
		}
		void Start (){
			GameObject go = GameObject.FindGameObjectWithTag("Player");

			target = go.transform;
		}
	void Update () {
	
		myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
		}


}