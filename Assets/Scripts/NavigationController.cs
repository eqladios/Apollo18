using UnityEngine;
using System.Collections;

public class NavigationController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void goToIntro()
    {
        Application.LoadLevel(0);
    }

    public void goToLevelOne()
    {
        Application.LoadLevel(1);
    }

    public void goToGameOver()
    {
        Application.LoadLevel(2);
    }

    public void quit()
    {
        Application.Quit();
    }
}
