using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 3f;

    void Start()
    {
        // Destroy the missile after a few seconds even if it doesn't hit anything
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // Move the missile forward
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    // Called when the missile enters another collider (the trigger)
    private void OnTriggerEnter(Collider other)
    {
        // Ignore the player who fired the missile
        if (other.CompareTag("Player"))
        {
            return;
        }

        if (other.CompareTag("Enemy"))
        {
            // Destroy the enemy the missile hit
            Destroy(other.gameObject);
        }

        // Destroy the missile itself on any other hit
        Destroy(gameObject);
    }
}
