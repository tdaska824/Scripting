using UnityEngine;

// Builds a simple blocky character out of six cubes.
public class CreatePrimitives : MonoBehaviour
{
    void Start()
    {
        Vector3[] positions =
        {
            new Vector3(0f, 0f, 0f),
            new Vector3(-0.5f, 1f, 0f),
            new Vector3(0.5f, 1f, 0f),
            new Vector3(0.5f, 2f, 0f),
            new Vector3(-0.5f, 2f, 0f),
            new Vector3(0f, 3f, 0f)
        };

        foreach (Vector3 position in positions)
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = position;
        }
    }
}
