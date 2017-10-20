using UnityEngine;
using System.Collections;

public class pickUp : MonoBehaviour {

    public int coinValue = 1;
    public AudioClip coinSound, coinSound2;

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "PlayerOne"||other.tag == "PlayerTwo")
        {
            FindObjectOfType<playerControl>().CollectCoin(this.coinValue);
            Destroy(this.gameObject);
            audiomanager.instance.randomizeSFX(coinSound, coinSound2);
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
