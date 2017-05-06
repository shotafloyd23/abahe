using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public Rigidbody playerBody;
    public float speedMultiplier;

    Vector3 deltaPos;

    void Start ()
    {
        deltaPos = Vector3.zero;
    }
	
	void Update ()
    {
        deltaPos.z = Input.GetAxis("Vertical");
        deltaPos.x = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        playerBody.AddForce(deltaPos * speedMultiplier);
    }
}
