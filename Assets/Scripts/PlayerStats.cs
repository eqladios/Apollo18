using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStats : MonoBehaviour
{ 
	public int health = 6;

	public float flickerDuration = 0.1f;
	public float flickerTime = 0f;

	private SpriteRenderer spriteRenderer;

	public bool immune = false;
	public float immunityDuration = 1.5f;
	private float immunityTime = 0f;
	public bool hitReaction = false;
    public static PlayerStats instance;
    public AudioClip gameOverSound;
    public int score = 0;
    public Slider healthBar;
  
	// Use this for initialization
	void Start()
	{
		spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
	}
    public void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this);
    }

    public void SpriteFlicker()
	{
		if (this.flickerTime < this.flickerDuration)
			this.flickerTime = this.flickerTime + Time.deltaTime;
		else if (this.flickerTime >= this.flickerDuration)
		{
			spriteRenderer.enabled = !spriteRenderer.enabled;
			this.flickerTime = 0;
		}
	}

	// Update is called once per frame
	void Update()
	{
		if (this.immune)
		{
			SpriteFlicker();
			immunityTime += Time.deltaTime;
			if (immunityTime >= immunityDuration)
			{
				this.immune = false;
				this.spriteRenderer.enabled = true;
			}
		}
		healthBar.value = health;

    }

	public void TakeDamage(int damage)
	{
		if (!this.immune)
		{
			this.health -= damage;
			if (this.health < 0f)
			{
				this.health = 0;
			}
			if (this.health <= 0f)
			{
                
                FindObjectOfType<levelManager>().respwanPlayer();
				this.immune = true;
				this.immunityTime = 0f;
			}

		}
		if (hitReaction)
		{

		}

	}
}
