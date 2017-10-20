using UnityEngine;
using System.Collections;

public class levelManager : MonoBehaviour {
    public GameObject CurrCheckpoint;
    public static levelManager instance;
    public GameObject enemy;
    public GameObject CurrenemyCheckpoint;
    // Use this for initialization
    void Start () 
	{
     
    }

	public void Awake()
	{
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(this.gameObject);
		DontDestroyOnLoad(this);
    }

	// Update is called once per frame
	void Update () 
	{
 
    }
    public void respwanPlayer()
    {
       
        FindObjectOfType<PlayerStats>().health = 6;
		FindObjectOfType<PlayerStatsTwo>().health = 6;
        FindObjectOfType<playerControl>().transform.position = CurrCheckpoint.transform.position;
        FindObjectOfType<playertwo>().transform.position = CurrCheckpoint.transform.position;
    }
    public void RespawnEnemy()
    {   
        Invoke("insta", 1);
    }
    public void insta()
    {
        Instantiate(enemy, CurrenemyCheckpoint.transform.position, CurrenemyCheckpoint.transform.rotation);
    }
}
