using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (player != null)
        {
            player.CollectCoins();  // Update the player's coin count
            Destroy(gameObject);
        }
    }
}
