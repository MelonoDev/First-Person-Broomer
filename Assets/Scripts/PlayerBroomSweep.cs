using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Add to player camera
public class PlayerBroomSweep : MonoBehaviour {

	public Rigidbody Sweep;
	public float SweepTime;

	void MakeSweep () {
		Vector3 frontPosition = transform.TransformPoint (0, 0, 2);
		Rigidbody sweepClone = (Rigidbody)Instantiate (Sweep, frontPosition, Sweep.transform.rotation);
	}

	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			MakeSweep ();
		}
	}
}
