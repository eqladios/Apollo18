using UnityEngine;
using System.Collections;

public class FollowerEnemy : EnemyController
{

    private playerControl player;
    public int moveSpeed = 1;
    public bool moving;
    private Animator EnemyAnime;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<playerControl>();
        this.isFacingRight = false;
        EnemyAnime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        EnemyAnime.SetFloat("enemyspeed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }

    //void FixedUpdate()
    //{
    //    if (this.isFacingRight)
    //    {
    //        this.GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
    //    }
    //    else
    //    {
    //        this.GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
    //    }
    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            Flip();
        }
        else if (other.tag == "Enemy")
        {
            Flip();
        }
        base.OnTriggerStay2D(other);
    }
}
