using UnityEngine;

public class moveCube : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed = 2f;

    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime, 
        Space.World);
    }
}
