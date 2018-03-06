using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Shoot : MonoBehaviour {

	private bool carryPuck;
	private bool shot;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find("Player").GetComponent<MovePlayer>().fall == false)
		{
			if (carryPuck == true && shot == false)
			{
				GameObject.Find("Puck").transform.position = this.transform.position + this.transform.forward / 3;
				if (Input.GetKey(KeyCode.Mouse0))
				{
					this.GetComponent<BoxCollider>().enabled = false;
					carryPuck = false;
					GameObject.Find("Puck").GetComponent<Rigidbody>()
						.AddForce((GameObject.Find("Puck").transform.position - this.transform.position) * 50, ForceMode.Impulse);
					GameObject.Find("Player").GetComponent<MovePlayer>().fall = true;
					shot = true;
				}
			}

			if (shot == true && GameObject.Find("Puck").GetComponent<Rigidbody>().velocity.x <= .1f
			                 && GameObject.Find("Puck").GetComponent<Rigidbody>().velocity.z <= .1f)
			{
				GameObject.Find("NetZone").GetComponent<Score>().ChangeLevel(3);
			}
		}
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.name.Contains("Puck"))
		{
			carryPuck = true;
		}
	}
}
