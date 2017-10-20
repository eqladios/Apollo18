using UnityEngine;
using System.Collections;

public class lastcheckpoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   public void OnTriggerEnter2D(Collider2D player) 
	{
		if(player.tag == "PlayerOne" || player.tag == "PlayerTwo")
        Application.LoadLevel("scene3");
    }
}
