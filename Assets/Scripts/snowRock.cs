using UnityEngine;
using System.Collections;

public class snowRock : MonoBehaviour 
{
	public int damage = 3;

	// Use this for initialization
	void Start () 
	{
	}

	// Update is called once per frame
	void Update () 
	{
		Destroy(this.gameObject, 20);

	}

	public void enable()
	{
		this.GetComponent<Rigidbody2D> ().gravityScale = Random.Range(1, 5);
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
		else if (other.name == "platformSnow")
			Destroy(this.gameObject);
	}
}
