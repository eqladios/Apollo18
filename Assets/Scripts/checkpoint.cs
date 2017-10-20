using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
			
	}

	void Awake()
	{
		//DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D other)
    {
		if (other.tag == "PlayerOne" || other.tag == "PlayerTwo") 
		{
			FindObjectOfType<levelManager> ().CurrCheckpoint = this.gameObject;
		}
//		if(this.tag=="checkpoint2")
//		{
//          	FindObjectOfType<levelManager>().RespawnEnemy();
//		}
        
    }
}
