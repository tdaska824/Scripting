using UnityEngine;

// Destroys the GameObject this script is attached to as soon as the game starts.
public class DestroyOnStart : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject);
    }
}
