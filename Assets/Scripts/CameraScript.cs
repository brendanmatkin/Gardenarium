using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	
	// How camera pitch (i.e. rotation about x axis) should vary with zoom
	public AnimationCurve pitchCurve;
	// How far the camera should be placed back along the chosen pitch based on zoom
	public AnimationCurve distanceCurve;
	
	// Use this for initialization
	void Start () {
		
		// Create 'S' shaped curve to adjust pitch
		// Varies from 0 (looking forward) at 0, to 90 (looking straight down) at 1
		pitchCurve = AnimationCurve.EaseInOut(0.0f, 0.0f, 1.0f, 90.0f);
		
		// Create exponential shaped curve to adjust distance
		// So zoom control will be more accurate at closer distances, and more coarse further away
		Keyframe[] ks = new Keyframe[2];
		// At zoom=0, offset by 0.5 units
		ks[0] = new Keyframe(0, 0.5f);
		ks[0].outTangent = 0;
		// At zoom=1, offset by 60 units
		ks[1] = new Keyframe(1, 60);
		ks[1].inTangent = 90;
		distanceCurve = new AnimationCurve(ks);
	}
}