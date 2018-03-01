using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Score : MonoBehaviour {

	public int count;
	private bool startTimer = false;
	private float Timer = 5f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (startTimer == true)
		{
			Timer -= Time.deltaTime;
		}

		if (Timer <= 0)
		{
			count++;
			startTimer = false;
			Timer = 5f;
			SceneManager.LoadScene(count);
		}
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene(count);
		}

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.name.Contains("Puck"))
		{
			this.GetComponent<AudioSource>().Play();
			startTimer = true;
		}
	}
}
