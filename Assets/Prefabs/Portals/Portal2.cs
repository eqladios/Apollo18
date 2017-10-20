using UnityEngine;
using System.Collections;

public class Portal2 : MonoBehaviour
{

    public Transform exit;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerTwo")
        {
            FindObjectOfType<playertwo>().transform.position = exit.position;
        }
        if (other.tag == "PlayerOne")
        {
            FindObjectOfType<playerControl>().transform.position = exit.position;
        }
    }
}
