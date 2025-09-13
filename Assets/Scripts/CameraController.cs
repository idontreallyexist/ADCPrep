using UnityEditor.Timeline;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target;
    public Vector3 offset;
    void Start()
    {
        offset = target.transform.position-transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position - offset;
    }
}
