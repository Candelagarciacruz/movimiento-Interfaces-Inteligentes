using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 100f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(0f, horizontalInput * rotationSpeed * Time.deltaTime, 0f);
        transform.Translate(transform.forward * speed * Time.deltaTime,
        Space.World);
        Debug.DrawRay(transform.position, transform.forward * 3f, Color.red);
    }
}
