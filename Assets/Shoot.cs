using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	private bool carryPuck;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (carryPuck == true)
		{
			GameObject.Find("Puck").transform.position = this.transform.position + this.transform.forward/3;
			if (Input.GetKey(KeyCode.Mouse0))
			{
				GameObject.Find("Player").GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
				GameObject.Find("Puck").GetComponent<Rigidbody>().AddForce((GameObject.Find("Puck").transform.position - this.transform.position) * 50, ForceMode.Impulse);
				carryPuck = false;
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
