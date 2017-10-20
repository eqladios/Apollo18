using UnityEngine;
using System.Collections;

public class spikes : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "PlayerOne" || other.tag == "PlayerTwo")
        {
            Debug.Log("respawn");
            FindObjectOfType<levelManager>().respwanPlayer();
        }
    }
}
