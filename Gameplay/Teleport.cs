using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Point to which the player will be teleported
    public Transform teleportPoint;

    // Called when the player enters the trigger area
    private void OnTriggerEnter(Collider other)
    {
        if (teleportPoint != null && other.CompareTag("Player"))
        {
            other.transform.position = teleportPoint.position;
        }
    }
}
