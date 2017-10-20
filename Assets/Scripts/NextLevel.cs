using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
		if(other.tag == "PlayerOne" || other.tag == "PlayerTwo")
       		Application.LoadLevel("scene2.0");
    }
}
