using UnityEngine;
using System.Collections;

public class EnemyDestroy2 : MonoBehaviour {
	void OnCollisionEnter(Collision collision) {

			StartCoroutine(Example()); //this will run your timer
		}
		
		IEnumerator Example() {
			yield return new WaitForSeconds(5); //this will wait 5 seconds 
		Destroy(gameObject);
		
	}
}