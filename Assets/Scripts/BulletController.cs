using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
    public float speed;
    private playerControl Player;
	// Use this for initialization

	void Start () 
    {
        Player = FindObjectOfType<playerControl>();
        if (Player.transform.localScale.x < 0)
            speed = -speed;
	}
	
	// Update is called once per frame
	void Update () 
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        Destroy(this.gameObject, 1);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            FindObjectOfType<playerControl>().score += 6;
        }
        if (other.tag == "boss")
        {
            FindObjectOfType<boss>().health -= 3;
            Destroy(this.gameObject);
            FindObjectOfType<playerControl>().score += 6;
        }
    }
}
