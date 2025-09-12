using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private CharacterController Controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int speed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            Controller.Move(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey("s"))
        {
            Controller.Move(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey("a"))
        {
            Controller.Move(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey("d"))
        {
            Controller.Move(Vector3.right * Time.deltaTime * speed);
        }
    }
}
