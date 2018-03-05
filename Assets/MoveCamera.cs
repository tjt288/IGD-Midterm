using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		this.transform.position = GameObject.Find("Player").transform.position + new Vector3(0, 2f, -2f);

	}
}
