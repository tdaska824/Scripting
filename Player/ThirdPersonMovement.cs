using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ThirdPersonMovement : MonoBehaviour
{
    public float speed = 5f;
    public float runSpeed = 9f;
    public float turnSpeed = 100f;
    public bool canRun = true;
    public bool isRunning;
    public KeyCode runningKey = KeyCode.LeftShift;

    private Rigidbody playerRigidbody;

    void Awake()
    {
        // Reference to the Rigidbody on the object this script is attached to
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        // Hide the cursor at the start of the game
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        // Running is allowed only if canRun is enabled and the running key is held
        isRunning = canRun && Input.GetKey(runningKey);
        float targetMovingSpeed = isRunning ? runSpeed : speed;

        float forwardInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        // Move along the character's forward direction.
        // The vertical velocity is kept so gravity and jumps still work.
        Vector3 move = transform.forward * forwardInput * targetMovingSpeed;
        playerRigidbody.velocity = new Vector3(move.x, playerRigidbody.velocity.y, move.z);

        // Rotate in place with A/D (or the left/right arrows)
        transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.fixedDeltaTime, Space.Self);
    }
}
