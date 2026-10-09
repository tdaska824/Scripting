using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;

    void Start()
    {
        // Higher level NPCs start with more health
        health += level;
        print("Updated health: " + health);
    }

    void Update()
    {
        // Walk along the z axis
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
