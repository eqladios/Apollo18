using UnityEngine;
using System.Collections;

public class outOfBounds : MonoBehaviour 
{
	public int damage = 1000;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "PlayerOne" )
		{
			//FindObjectOfType<PlayerStats>().hitReaction = true;
			FindObjectOfType<PlayerStats>().TakeDamage(damage);
		}
		else if(other.tag == "PlayerTwo")
		{
			//FindObjectOfType<PlayerStatsTwo>().hitReaction = true;
			FindObjectOfType<PlayerStatsTwo>().TakeDamage(damage);
		}
	}
}
