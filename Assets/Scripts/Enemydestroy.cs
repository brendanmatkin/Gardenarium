using UnityEngine;
using System.Collections;

public class Enemydestroy : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Enemy"){
			Destroy(other.gameObject);
		}
	}
}