using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
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
        // Launch a fireball on left click
        if (Input.GetMouseButtonDown(0) && fireballPrefab != null && attackPoint != null)
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
