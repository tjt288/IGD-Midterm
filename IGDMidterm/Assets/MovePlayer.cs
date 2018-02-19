using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	private Rigidbody playerBody;
	public float forwardForce;
	public float backwardForce;
	public float turnForce;
	
	// Use this for initialization
	void Start () {
		playerBody = this.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

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
			transform.localEulerAngles += new Vector3(0,2f,0);
		}
		
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			transform.localEulerAngles -= new Vector3(0,2f,0);
		}
		
	}
}
