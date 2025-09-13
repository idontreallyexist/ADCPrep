using UnityEditor.Timeline;
using UnityEngine.InputSystem;
using UnityEngine;
using Unity.VisualScripting;

public class CameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target;
    public Transform pivot;
    public Vector3 offset;
    public float mouseSpeed = 5.0f;
    void Start()
    {
        offset = target.transform.position-transform.position;
        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Mouse.current.position.ReadValue().x * mouseSpeed;
        float vertical = Mouse.current.position.ReadValue().y * -1;
        float desiredXAngle = target.eulerAngles.x;
        float desiredYAngle = target.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);
        if (transform.position.y < target.position.y) {
            transform.position = new Vector3(transform.position.x, target.position.y - 0.5f, transform.position.z);
        }
        transform.LookAt(target);
        if (pivot.eulerAngles.x > 60f && pivot.eulerAngles.x < 180f) {
            pivot.rotation = Quaternion.Euler(60f, 0, 0);
        }
        target.Rotate(0, horizontal, 0);
        if (pivot.eulerAngles.x > 180f && pivot.eulerAngles.x < 330f)
        {
            pivot.rotation = Quaternion.Euler(330f, 0, 0);
        }
        pivot.Rotate(vertical, 0, 0);
    }
}
