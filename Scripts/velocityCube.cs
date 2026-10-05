using UnityEngine;

public class velocityCube : MonoBehaviour
{
    public float velocity = 4f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalResult = velocity * horizontalInput;
        float verticalResult = velocity * verticalInput;

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Flecha arriba: " + verticalResult);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Flecha abajo: " + verticalResult);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Debug.Log("Flecha izquierda: " + horizontalResult);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Debug.Log("Flecha derecha: " + horizontalResult);
        }
    }
}
