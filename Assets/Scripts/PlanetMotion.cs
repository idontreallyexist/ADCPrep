using UnityEngine;

public class PlanetMotion : MonoBehaviour
{
    public float distance;
    public float speed;
    public float selfRotateSpeed;
    float degrees = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, 50, distance);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(degrees*Mathf.PI/180) * distance,
            50,
            Mathf.Cos(degrees * Mathf.PI / 180) * distance);
        degrees = degrees + Time.deltaTime*speed;
        transform.Rotate(Vector3.up * selfRotateSpeed * Time.deltaTime);
    }
}
