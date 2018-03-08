using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsText : MonoBehaviour
{

	private int count;
	
	// Use this for initialization
	void Start ()
	{

		this.GetComponent<TextMesh>().text = "This is me, taking a\npenalty shot at my\nsenior night for my\nhigh scool hockey team.";
		GameObject.Find("Arrow").transform.position = new Vector3(5f, 4.5f, 0);
		GameObject.Find("Arrow").transform.eulerAngles = new Vector3(0,0,-110f);
		
	}

	public void AdvanceText()
	{
		count++;

		if (count == 1)
		{
			this.GetComponent<TextMesh>().text = "I made a sweet move,\nthe goalie slid left,\nand I deked to the right.";
			GameObject.Find("Arrow").transform.position = new Vector3(1f,2f,0);
			GameObject.Find("Arrow").transform.eulerAngles = new Vector3(0,0,-180f);
			GameObject.Find("Other").GetComponent<MeshRenderer>().enabled = true;
		}

		if (count == 2)
		{
			this.GetComponent<TextMesh>().text = "The puck is on my stick,\nand all I have to do is\ntap it into the net.";
			GameObject.Find("Arrow").transform.position = new Vector3(6.5f,-2.5f,0);
			GameObject.Find("Arrow").transform.eulerAngles = new Vector3(0,0,90f);
			GameObject.Find("Arrow").GetComponent<TextMesh>().fontSize = 200;
			GameObject.Find("Other").GetComponent<MeshRenderer>().enabled = false;
		}

		if (count == 3)
		{
			this.GetComponent<TextMesh>().text = "I missed that shot.";
			this.GetComponent<TextMesh>().fontSize = 90;
			this.GetComponent<TextMesh>().fontStyle = FontStyle.Bold;
			GameObject.Find("Arrow").GetComponent<MeshRenderer>().enabled = false;
		}
		
		if (count == 4)
		{
			this.GetComponent<TextMesh>().text = "But maybe\nyou can do better!";
			this.GetComponent<TextMesh>().fontSize = 75;
			this.GetComponent<TextMesh>().fontStyle = FontStyle.Normal;
		}

		if (count == 5)
		{
			this.GetComponent<TextMesh>().text = "Skate using WASD\nor the Arrow Keys.";
		}
		
		if (count == 6)
		{
			this.GetComponent<TextMesh>().text = "Control the stick\nwith your mouse.";
		}
		
		if (count == 7)
		{
			this.GetComponent<TextMesh>().text = "Shoot the puck by\npressing the spacebar.";
		}
		
		if (count == 8)
		{
			this.GetComponent<TextMesh>().text = "And since it's\na penalty shot,\nyou can only shoot once.";
		}
		
		if (count == 9)
		{
			this.GetComponent<TextMesh>().text = "Good Luck!";
			this.GetComponent<TextMesh>().fontSize = 100;
			GameObject.Find("Continue").SetActive(false);
//			GameObject.Find("Play").SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
