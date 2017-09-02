using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 1f;

	private Vector3 playerPos = new Vector3(0, -9.0f, 0);

	void Update()
	{
		float LocalInput = Input.GetAxis("Horizontal") == 0.0f ? Input.GetAxis("Mouse X") : Input.GetAxis("Horizontal");
		float xPos = transform.position.x + (LocalInput * paddleSpeed);
		playerPos = new Vector3(Mathf.Clamp(xPos, -7.5f, 7.5f), -9.0f, 0f);
		transform.position = playerPos;
	}
}
