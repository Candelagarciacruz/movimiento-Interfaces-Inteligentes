using UnityEngine;

public class moveSphereWithKeys : MonoBehaviour
{
    public float speed = 2f;    

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) ||
          Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) {
            transform.Translate(movement * speed * Time.deltaTime);
        }
    }
}
