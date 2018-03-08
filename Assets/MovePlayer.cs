using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	private Rigidbody playerBody;
	private bool onceOnly;
	public bool fall;
	public float forwardForce;
	public float backwardForce;
	public float sideForce;
	public float maxVelocity;
	
	// Use this for initialization
	void Start () {
		playerBody = this.gameObject.GetComponent<Rigidbody>();
		fall = false;
		onceOnly = false;
	}
	
	void FixedUpdate () {

		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && fall == false)
		{
			playerBody.AddForceAtPosition(new Vector3(0,0,forwardForce), transform.position + new Vector3(0,.1f,.1f));
//			playerBody.AddRelativeForce(Vector3.forward * forwardForce);
		}
		
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && fall == false)
		{
			playerBody.AddForceAtPosition(new Vector3(0,0,-backwardForce), transform.position + new Vector3(0,.1f,-.1f));
//			playerBody.AddRelativeForce(Vector3.back * backwardForce);
		}
		
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) && fall == false)
		{
			playerBody.AddForceAtPosition(new Vector3(sideForce,0,0), transform.position + new Vector3(-.1f,.1f,0));
//			transform.localEulerAngles += new Vector3(0,2f,0);
		}
		
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) && fall == false)
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

		if (((this.transform.eulerAngles.x >= 89f && this.transform.eulerAngles.x <= 91f  )
		    || (this.transform.eulerAngles.z >= 89f && this.transform.eulerAngles.z <= 91f)
		    || (this.transform.eulerAngles.x >= 269f && this.transform.eulerAngles.x <= 271f)
		    || (this.transform.eulerAngles.z >= 269f && this.transform.eulerAngles.z <= 271f))
		    && onceOnly == false)		
		{
			fall = true;
			GameObject.Find("NetZone").GetComponent<Score>().ChangeLevel(3);
			this.GetComponent<AudioSource>().time = Random.Range(0, 10);
			this.GetComponent<AudioSource>().Play();
			onceOnly = true;
		}

		if (fall == true)
		{
			playerBody.freezeRotation = true;
		}
		
	}
}
