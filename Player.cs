using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health;

   
    public GameObject fireballPrefab;

    // The point where fireballs are launched from (assign in Inspector)
    public Transform attackPoint;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }

    void Update()
    {
        // Launch fireball on left click
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
