using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private CharacterController controller;
    public Animator anim;
    public Transform hitObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int speed = 3;
    float movex;
    float movez;
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
            movex = transform.forward.x * Time.deltaTime * speed;
            movez = transform.forward.z * Time.deltaTime * speed;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            controller.Move(-transform.forward * Time.deltaTime * speed);
            movex = transform.forward.x * Time.deltaTime * speed;
            movez = transform.forward.z * Time.deltaTime * speed;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            controller.Move(-transform.right * Time.deltaTime * speed);
            movex = transform.forward.x * Time.deltaTime * speed;
            movez = transform.forward.z * Time.deltaTime * speed;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            controller.Move(transform.right * Time.deltaTime * speed);
            movex = transform.forward.x * Time.deltaTime * speed;
            movez = transform.forward.z * Time.deltaTime * speed;
        }
        if (Keyboard.current.spaceKey.isPressed && controller.isGrounded) {
            controller.Move(transform.up * Time.deltaTime * speed * 8);
        }
        if (!controller.isGrounded) {
            controller.Move(-transform.up * Time.deltaTime * Time.deltaTime * 20);
        }   

        anim.SetFloat("Speed", new Vector3(movex, 0, movez).magnitude);
        anim.SetBool("IsGrounded", controller.isGrounded);
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.tag == "Barrel") {
            Debug.Log("Hit");
            var audio = hit.gameObject.GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
