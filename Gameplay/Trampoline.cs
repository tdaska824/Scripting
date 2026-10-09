using UnityEngine;

// Requires a Jump component on the player with a public float jumpStrength
// (Jump.cs is not part of this repository).
public class Trampoline : MonoBehaviour
{
    public float trampolineJumpStrength = 10f;

    private float originalJumpStrength;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Jump playerJump = other.GetComponent<Jump>();
            if (playerJump != null)
            {
                // Remember the normal jump strength so it can be restored on exit
                originalJumpStrength = playerJump.jumpStrength;
                playerJump.jumpStrength = trampolineJumpStrength;
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
                playerJump.jumpStrength = originalJumpStrength;
            }
        }
    }
}
