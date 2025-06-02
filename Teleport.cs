using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Point to which the player will be teleported
    public Transform teleportPoint;

    // Called when the player enters the trigger area
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Move the player to the teleport point's position
            other.transform.position = teleportPoint.position;
        }
    }
}
