using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour
{
    public Transform player1, player2;
    public float minSizeY = 3;
	public float h = 0.5f;
	public float w = 0.5f;
	public float m = 0.5f;
	//public float minSizeY = 12.61f;
	public float maxSizeY = 3.5f;

    void SetCameraPos()
    {
		Vector3 middle = (player1.position + player2.position) * m;
		Vector3 playerY = (player1.position + player2.position) * 0.2f;
		GetComponent<Camera>().transform.position = new Vector3(middle.x,playerY.y,GetComponent<Camera>().transform.position.z);
    }

    void SetCameraSize()
    {
		//float camSizeX = Mathf.Max(width, minSizeX);
		//camera.orthographicSize = Mathf.Clamp (Mathf.Max (height,   camSizeX * Screen.height / Screen.width, minSizeY), minSizeY, maxSizeY);

        //horizontal size is based on actual screen ratio
        float minSizeX = minSizeY * Screen.width / Screen.height;

        //multiplying by 0.5, because the ortographicSize is actually half the height
        float width = Mathf.Abs(player1.position.x - player2.position.x) * h;
        float height = Mathf.Abs(player1.position.y - player2.position.y) * w;

        //computing the size
        float camSizeX = Mathf.Max(width, minSizeX);
		GetComponent<Camera>().orthographicSize = Mathf.Clamp (Mathf.Max (height,   camSizeX * Screen.height / Screen.width, minSizeY), minSizeY, maxSizeY);
    }

    void Update()
    {
        SetCameraPos();
        SetCameraSize();
		//GetComponent<Camera> ().orthographicSize = orthographicSize;
    }
}
