using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerControl : MonoBehaviour {
    public float moveSpeed;
    public float jumpHeight;
    public bool facingRight;
    public KeyCode jump;
    public KeyCode left;
    public KeyCode right;
    public KeyCode shootingKey;
    public bool grounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask WhatIsGround;
    private Animator Anime;
    public int score = 0;
    public AudioClip jump1;
    public AudioClip jump2;
    public Transform firePoint;
    public GameObject bullet;
    public Text scoreUI;
    public bool shooting = false;

    // Use this for initialization
    void Start()
    {
        facingRight = true;
        Anime = GetComponent<Animator>();
    }


    void flip()
    {
        transform.localScale = new Vector3(-(GetComponent<Transform>().localScale.x), GetComponent<Transform>().localScale.y, GetComponent<Transform>().localScale.z);
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, WhatIsGround);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            if (facingRight)
            {
                //transform.localScale = new Vector3(-(GetComponent<Transform>().localScale.x), GetComponent<Transform>().localScale.y, GetComponent<Transform>().localScale.z);
                flip();
                facingRight = false;
            }
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(right))
        {
            if (!facingRight)
            {
                //transform.localScale = new Vector3(-(GetComponent<Transform>().localScale.x), GetComponent<Transform>().localScale.y, GetComponent<Transform>().localScale.z);
                flip();
                facingRight = true;
            }
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKeyDown(jump) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            audiomanager.instance.randomizeSFX(jump1, jump2);
        }

        if (Input.GetKeyDown(shootingKey) && grounded)
        {
            shoot();
        }

        Anime.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        Anime.SetBool("grounded", grounded);
        scoreUI.text = "" + score;
    }

    public void CollectCoin(int value)
    {
        score += value;
    }

    public void shoot()
    {
        Anime.SetTrigger("isShooting");
    }

    public void createBullet()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }


}

