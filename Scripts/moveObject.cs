using UnityEngine;

public class moveObject : MonoBehaviour
{
    public  Vector3 displacement;

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space)) {
        transform.Translate(displacement);
      }    
    }
}
