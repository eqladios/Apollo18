using UnityEngine;
using System.Collections;

public class shooingEnemy : EnemyController 
{

	public float DistanceFromPlayer,CoolDown;
	public GameObject target;
	public GameObject bullet;
	//public GameObject enemyld;
	public int protectionRadius;
	public Transform firePoint;
	public int MoveSpeed = 1;

	// Use this for initialization
	void Start () 
	{
		protectionRadius = 10;
		CoolDown = 1;
		this.isFacingRight = false;
	}

	// Update is called once per frame
	void Update () 
	{
		if(target != null)
		{
			DistanceFromPlayer = Vector3.Distance(target.transform.position,this.transform.position);
			if(DistanceFromPlayer <= protectionRadius)
			{
				attackEnemy();
			}

		}
	}
	void attackEnemy()
	{
		CoolDown -= Time.deltaTime;
		if (CoolDown <= 0)
		{
			//Instantiate(bullet,Vector3.forward,Quaternion.identity);
			Instantiate(bullet, firePoint.position, firePoint.rotation);
			//Instantiate(enemyld, firePoint.position, firePoint.rotation);
			//Instantiate(bullet, firePoint.position, firePoint.rotation);
			CoolDown = 5;
		}
	}
}