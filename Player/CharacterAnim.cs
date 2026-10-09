using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;

    private int isWalkingHash;
    private int isRunningHash;

    void Start()
    {
        // Get the parameter IDs once instead of looking them up by name every frame
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        // Walk while W is held, run while W and left shift are both held
        animator.SetBool(isWalkingHash, forwardPressed);
        animator.SetBool(isRunningHash, forwardPressed && runPressed);
    }
}
