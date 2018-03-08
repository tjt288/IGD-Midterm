using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
	private int count = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick()
	{
		count++;
		SceneManager.LoadScene(count);
	}
	
	public void OnClick2()
	{
		SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
	}
	
	public void OnClick3()
	{
		SceneManager.LoadScene(1);
	}
}
