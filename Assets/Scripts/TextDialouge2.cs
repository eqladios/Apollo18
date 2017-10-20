using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextDialouge2 : MonoBehaviour {

    public Text dialouge_text; 
    string String_Text;
    int text_counter = 0; 
	// Use this for initialization
	void Start () {
//        dialouge_text = GameObject.Find("Dialouge_text").GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {
        dialouge_text.text = String_Text; 
        if (text_counter == 0)
        {
            String_Text = "Morgan and Emma have finally found what they were looking for, now they will return to their ship to go home.";
        }
       
        if (text_counter == 1)
        {
            Application.LoadLevel("scene2.1");
        }

	}


    public void OnCLickNext() 
    {
        text_counter++; 
    }
    
    
}
