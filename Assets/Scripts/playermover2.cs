using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover2 : MonoBehaviour
{
	public Rigidbody playerBody1;
	public float speedMultiplier1;

	Vector3 deltaPos;

	void Start ()
	{
		deltaPos = Vector3.zero;
	}

	void Update ()
	{
		deltaPos.z = Input.GetAxis("HorizontalWAS");
		deltaPos.x = Input.GetAxis("VerticalWASD");
	}

	void FixedUpdate()
	{
		playerBody1.AddForce(deltaPos * speedMultiplier1);
	}
}
