using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	private Rigidbody playerBody;
	public float forwardForce;
	public float backwardForce;
	
	// Use this for initialization
	void Start () {
		playerBody = this.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
		{
			playerBody.AddForceAtPosition(new Vector3(0,0,forwardForce), transform.position + new Vector3(0,.1f,.1f));
		}
		
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.A))
		{
			playerBody.AddForceAtPosition(new Vector3(0,0,backwardForce), transform.position + new Vector3(0,.1f,-.1f));
		}
		
	}
}
