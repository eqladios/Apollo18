using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

	// Use this for initialization
    public bool Friendly ;
    int damage = 100;
    public Animator LaserAnime;
   
	void Start () 
    {
        LaserAnime = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerStay2D(Collider2D other)
    {
        if (!Friendly)
        {
            if (other.tag == "PlayerOne")
            {
                FindObjectOfType<PlayerStats>().TakeDamage(damage);
            }
			if (other.tag == "PlayerTwo")
			{
				FindObjectOfType<PlayerStatsTwo>().TakeDamage(damage);
			}
        }
    }
}
