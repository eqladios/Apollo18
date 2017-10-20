using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextDialouge : MonoBehaviour {

	public Text dialouge_text; 
	string String_Text;
	int text_counter = 0; 
	// Use this for initialization
	void Start () {
		dialouge_text = GameObject.Find("dialouge_text").GetComponent<Text>();

	}

	// Update is called once per frame
	void Update () {
		dialouge_text.text = String_Text; 
		if (text_counter == 0)
		{
			String_Text = "After spending a month on Pluto, having made a lot of great discoveries, Morgan and Emma have only two objectives left before they return to planet earth.";
		}
		if (text_counter == 1)
		{
			String_Text = "They have to collect two last pieces of important scientific value from the planet, then return to their spaceship. ";
		}
		if (text_counter == 2)
		{
			String_Text = "Controls are Up, Right , Left arrows and Right-shift for Emma. And W, A, D, E for Morgan.";
		}
		if (text_counter == 3)
		{
			Application.LoadLevel("scene1.1");
		}


	}


	public void OnCLickNext() 
	{
		text_counter++; 
	}
	public void OnCLickBack()
	{
		text_counter--;
	}


}
