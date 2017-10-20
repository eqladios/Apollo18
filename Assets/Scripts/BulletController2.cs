using UnityEngine;
using System.Collections;

public class BulletController2 : MonoBehaviour
{
    public float speed;
    private playertwo Player;
    // Use this for initialization

    void Start()
    {
        Player = FindObjectOfType<playertwo>();
        if (Player.transform.localScale.x < 0)
            speed = -speed;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        Destroy(this.gameObject,1);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            FindObjectOfType<playertwo>().score += 6;
        }
       
            
    }
}
