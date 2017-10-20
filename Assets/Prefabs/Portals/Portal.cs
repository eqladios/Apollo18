using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerTwo")
        {
            FindObjectOfType<playertwo>().transform.position = FindObjectOfType<ExitingPortal>().transform.position;
        }
       
    }
}
