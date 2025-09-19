using System;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class SpaceCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target;
    public Vector3 offset;
    public float mouseSpeed;
    public float prevHorizontal = 0;
    public float prevVertical = 0;
    void Start()
    {
        offset = target.transform.position-transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Mouse.current.position.ReadValue().x * mouseSpeed;
        float vertical = Mouse.current.position.ReadValue().y * mouseSpeed * -2 + 90;
        float desiredXAngle = target.eulerAngles.x;
        float desiredYAngle = target.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);
        transform.LookAt(target);
        target.Rotate(0, horizontal-prevHorizontal, 0);
        prevHorizontal = horizontal;
        target.Rotate(vertical-prevVertical, 0, 0);
        prevVertical = vertical;
        Debug.Log(Convert.ToString(Mouse.current.position.ReadValue().x) + "," + Convert.ToString(Mouse.current.position.ReadValue().y));
    }
}
