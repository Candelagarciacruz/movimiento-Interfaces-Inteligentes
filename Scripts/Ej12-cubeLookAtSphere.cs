using UnityEngine;

public class cubeLookAtSphere : MonoBehaviour
{
    public float speed = 2f;    

    void Update()
    {
        GameObject sphere = GameObject.FindWithTag("Sphere");
        Vector3 positionSphere = sphere.transform.position;
        positionSphere.y = transform.position.y;
        transform.LookAt(positionSphere);

        Vector3 directionVector = positionSphere - transform.position;
        directionVector.y = 0f;
        transform.Translate(directionVector.normalized * speed * Time.deltaTime,
        Space.World);
    }
}
