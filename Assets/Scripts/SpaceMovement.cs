using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceMovement : MonoBehaviour
{
    private CharacterController controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int speed = 3;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            controller.Move(transform.forward * Time.deltaTime * speed);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            controller.Move(-transform.forward * Time.deltaTime * speed);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            controller.Move(-transform.right * Time.deltaTime * speed);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            controller.Move(transform.right * Time.deltaTime * speed);
        }
    }
}
