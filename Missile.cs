using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;

    
    void Start()
    {
        // Destroy the missile after 3 seconds even if it doesn't hit anything
        Destroy(gameObject, 3);
    }

   
    void Update()
    {
        // Move the missile forward
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    // This method is called when the missile collides with another collider
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Enemy"))
        {
            // Destroy the enemy GameObject the missile collided with
            Destroy(other.gameObject);
        }

        // Destroy the missile itself on any collision
        Destroy(gameObject);
    }
}
