using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public int damage = 6;
    public int health;
    public bool isFacingRight = false;
	public Vector3 firstPosition;
	// Use this for initialization
	void Start () 
	{
		firstPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 enemyScale = this.transform.localScale;
        enemyScale.x = enemyScale.x * -1;
        this.transform.localScale = enemyScale;
    }

    public void OnTriggerStay2D(Collider2D other)
    {
		if (other.tag == "PlayerOne" )
        {
            FindObjectOfType<PlayerStats>().hitReaction = true;
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
        }
        else if(other.tag == "PlayerTwo")
        {
            FindObjectOfType<PlayerStatsTwo>().hitReaction = true;
            FindObjectOfType<PlayerStatsTwo>().TakeDamage(damage);
        }
    }

	public void respawnEnemy()
	{
		this.transform.position = firstPosition;
	}


}
