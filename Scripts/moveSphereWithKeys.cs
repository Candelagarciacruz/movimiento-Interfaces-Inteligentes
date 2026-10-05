using UnityEngine;

public class moveSphereWithKeys : MonoBehaviour
{
    public float speed = 2f;    

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal2");
        float verticalInput = Input.GetAxis("Vertical2");
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
