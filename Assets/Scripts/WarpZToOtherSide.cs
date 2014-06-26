using UnityEngine;
using System.Collections;

public class WarpZToOtherSide : MonoBehaviour {

	public float positiveZLimit = 10f;
	public float negativeZLimit = -10f;
	public GameObject camera;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.z > positiveZLimit) {

			//first, parent the camera to player
			camera.transform.parent = gameObject.transform;

			//now warp player to -z limit
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, negativeZLimit);

			//now unparent the camera from the player
			camera.transform.parent = null;

		}

		if (gameObject.transform.position.z < negativeZLimit) {

						//first, parent the camera to player
						camera.transform.parent = gameObject.transform;

						//now warp player to +z limit
						gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, positiveZLimit);

						//now unparent the camera from the player
						camera.transform.parent = null;

				}
	}

}
