using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
	// Use this for initialization
	public Laser target;
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    void FixedUpdate() 
    {
		//target.Friendly = false;
		//target.LaserAnime.SetBool("TurnedOff", target.Friendly);
    }

	public void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "PlayerOne" || other.tag == "PlayerTwo") {
			target.Friendly = true;
			target.LaserAnime.SetBool ("TurnedOff", target.Friendly);
		} 
    }

	public void OnTriggerExit2D(Collider2D other)
	{
		target.Friendly = false;
		target.LaserAnime.SetBool("TurnedOff", target.Friendly);
	}
}
