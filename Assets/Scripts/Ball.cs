using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float ballInitialVelocity = 600f;

	private Rigidbody rigidBody;
	private bool ballInPlay;

	void Awake()
	{
		rigidBody = GetComponent<Rigidbody>();
		ballInPlay = false;
	}

	void Update()
	{
		if (Input.GetButtonDown("Fire1") && ballInPlay == false)
		{
			transform.parent = null;
			ballInPlay = true;
			rigidBody.isKinematic = false;
			rigidBody.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
		}
	}
}
