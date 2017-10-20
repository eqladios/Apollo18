using UnityEngine;
using System.Collections;

public class triggerSnow : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "PlayerOne" || other.tag == "PlayerTwo")
		{
			//FindObjectsOfType<snowRock>().enable();

			snowRock [] snowRocks = FindObjectsOfType<snowRock> ();
			for (int i = 0; i < snowRocks.Length; i++) 
			{
				snowRocks [i].enable ();
			}
		}
	}
}
