using UnityEngine;
using System.Collections;

public class CameraPosition2 : MonoBehaviour
{

    public Transform target;
    public float smooth;
    private Vector3 offset;

    public Transform[] Backgrounds;
    public float ParallaxScale;
    public float ParallaxReductionFactor;
    public float smoothing;
    private Vector3 lastPos;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var parallax = (lastPos.x - transform.position.x) * ParallaxScale;
        for (var i = 0; i < Backgrounds.Length; i++)
        {
            var targetPos = Backgrounds[i].position.x + parallax * (i + ParallaxReductionFactor + 1);
            Backgrounds[i].position = Vector3.Lerp(Backgrounds[i].position, new Vector3(targetPos, Backgrounds[i].position.y, Backgrounds[i].position.z), smoothing * Time.deltaTime);
        }
        lastPos = transform.position;
    }

    void FixedUpdate()
    {
        Vector3 camPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, camPos, smooth * Time.deltaTime);
    }
}
