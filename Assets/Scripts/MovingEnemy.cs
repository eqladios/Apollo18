using UnityEngine;
using System.Collections;

public class MovingEnemy : EnemyController {

    public int maxSpeed = 1;
    private Animator EnemyAnime;

	// Use this for initialization
	void Start () 
    {
        EnemyAnime = GetComponent<Animator>();
        this.isFacingRight = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	}

    void FixedUpdate()
    {
        if (this.isFacingRight)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Wall")
        {
            Flip();
        }
        else if (other.tag == "Enemy")
        {
            Flip();
        }
		else if (other.tag == "PlayerOne" )
		{
			
			FindObjectOfType<PlayerStats>().TakeDamage(damage);
		}
		else if(other.tag == "PlayerTwo")
		{
			
			FindObjectOfType<PlayerStatsTwo>().TakeDamage(damage);
		}
       
    }
}
