using UnityEngine;

public class moveCubeToSphere : MonoBehaviour
{
    public float speed = 2f;    

    void Update()
    {
        GameObject sphere = GameObject.FindWithTag("Sphere");
        Vector3 directionVector = sphere.transform.position - transform.position;
        directionVector.y = 0f;
        transform.Translate(directionVector.normalized * speed * Time.deltaTime);
    }
}
