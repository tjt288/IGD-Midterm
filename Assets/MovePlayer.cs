using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	private Rigidbody playerBody;
	public float forwardForce;
	public float backwardForce;
	public float sideForce;
	public float maxVelocity;
	
	// Use this for initialization
	void Start () {
		playerBody = this.gameObject.GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {

		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
		{
			playerBody.AddForceAtPosition(new Vector3(0,0,forwardForce), transform.position + new Vector3(0,.1f,.1f));
//			playerBody.AddRelativeForce(Vector3.forward * forwardForce);
		}
		
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
		{
			playerBody.AddForceAtPosition(new Vector3(0,0,-backwardForce), transform.position + new Vector3(0,.1f,-.1f));
//			playerBody.AddRelativeForce(Vector3.back * backwardForce);
		}
		
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		{
			playerBody.AddForceAtPosition(new Vector3(sideForce,0,0), transform.position + new Vector3(-.1f,.1f,0));
//			transform.localEulerAngles += new Vector3(0,2f,0);
		}
		
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			playerBody.AddForceAtPosition(new Vector3(-sideForce,0,0), transform.position + new Vector3(.1f,.1f,0));
//			transform.localEulerAngles -= new Vector3(0,2f,0);
		}

		if (playerBody.velocity.x > maxVelocity)
		{
			playerBody.velocity = new Vector3(maxVelocity, playerBody.velocity.y, playerBody.velocity.z);
		}
		
		if (playerBody.velocity.x < -maxVelocity)
		{
			playerBody.velocity = new Vector3(-maxVelocity, playerBody.velocity.y, playerBody.velocity.z);
		}
		
		if (playerBody.velocity.z > maxVelocity)
		{
			playerBody.velocity = new Vector3(playerBody.velocity.x, playerBody.velocity.y, maxVelocity);
		}
		
		if (playerBody.velocity.z < -maxVelocity)
		{
			playerBody.velocity = new Vector3(playerBody.velocity.x, playerBody.velocity.y, -maxVelocity);
		}
		
	}
}
