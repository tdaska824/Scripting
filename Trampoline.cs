using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Jump playerJump = other.GetComponent<Jump>();
            if (playerJump != null)
            {
                playerJump.jumpStrength = 10f;
                print("Player entered trampoline zone. Jump strength set to: " + playerJump.jumpStrength);
            }
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Jump playerJump = other.GetComponent<Jump>();
            if (playerJump != null)
            {
                playerJump.jumpStrength = 2f;
               
            }
        }
    }
}
