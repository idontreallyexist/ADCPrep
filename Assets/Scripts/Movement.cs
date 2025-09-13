using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private CharacterController controller;
    public Transform hitObject;
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

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.tag == "Barrel") {
            Debug.Log("Hit");
            var audio = hit.gameObject.GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
