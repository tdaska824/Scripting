using UnityEngine;

public class Player : MonoBehaviour
{
    private int health;

    // New field to track coins collected
    private int coins = 0;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }

    public void CollectCoins()
    {
        coins++;
        print("Coins collected: " + coins);
    }

    void Update()
    {
        // Fireball launch on left click
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}

