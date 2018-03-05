using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HockeyStick : MonoBehaviour
{
	// Use this for initialization
	void Start () {
		
	}

	private void FixedUpdate()
	{
		this.transform.position = GameObject.Find("Player").transform.position + new Vector3(-.5f, 0, .5f);
		if (Camera.main.ScreenToViewportPoint(Input.mousePosition).y < .5f && Camera.main.ScreenToViewportPoint(Input.mousePosition).x > .5f)
		{
			this.transform.eulerAngles = new Vector3(0,
				                             -1f +
				                             Camera.main.ScreenToViewportPoint(Input.mousePosition).x +
				                             1f - Camera.main.ScreenToViewportPoint(Input.mousePosition).y, 0) * 100;
		}
		else
		{
			this.transform.eulerAngles = new Vector3(0,
				                             -1f +
				                             Camera.main.ScreenToViewportPoint(Input.mousePosition).x +
				                             .5f, 0) * 100;
		}

//		var pos = Camera.main.WorldToScreenPoint(transform.position);
//		var dir = Input.mousePosition - pos;
//		var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
//		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); 
	}

	private void OnCollisionEnter(Collision other)
	{
		if (Input.GetKey(KeyCode.Mouse0))
		{
//			other.rigidbody.AddRelativeForce((GameObject.Find("Base").transform.position - other.transform.position) * 100);
		}
	}
}
