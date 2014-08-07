using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour 
{
	public GameObject enemy;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (EnemySpawn ());
	
	}
	
	IEnumerator EnemySpawn ()
	{
		while (true) {
						Instantiate (enemy, transform.position, Quaternion.identity);
			yield return new WaitForSeconds (Random.Range(5F, 25F));
		}
		
	}
}
