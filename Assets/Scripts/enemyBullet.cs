using UnityEngine;
using System.Collections;

public class enemyBullet : MonoBehaviour {
	public float speed;
	public int damage = 3;
	private EnemyController enemy;
	// Use this for initialization

	void Start () 
	{
		enemy = FindObjectOfType<EnemyController>();
		if (enemy.transform.localScale.x < 0)
			speed = -speed;
	}

	// Update is called once per frame
	void Update () 
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
		Destroy (gameObject, 3);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "PlayerTwo")
		{
			
			FindObjectOfType<PlayerStatsTwo>().TakeDamage(damage);
			Destroy(this.gameObject);
			
		}
      else  if (other.tag == "PlayerOne")
        {
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
