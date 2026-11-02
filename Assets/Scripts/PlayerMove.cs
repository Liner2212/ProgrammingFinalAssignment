using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    public float sprintSpeed = 7f;
    public float jumpForce = 5f;

    public Rigidbody body;

    // I'm only watching this one. The code sets it every frame.
    public float currentSpeed;


    void Start()
    {

    }

    void Update()
    {
        /*
        if (transform.position.z > 20)
        {
            transform.position = new Vector3(0, 1, 0);
        }
        */

        // First, I'm deciding how fast to go this frame
        if (Keyboard.current.leftShiftKey.isPressed)
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = moveSpeed;
        }


        // Keep your Shift if/else exactly as it is. Delete the step line
        // and the four Translate lines. Put this in their place:

        // Which way do the keys point? -1, 0 or 1
        float x = 0f;
        float z = 0f;
        if (Keyboard.current.wKey.isPressed) { z = 1f; }
        if (Keyboard.current.sKey.isPressed) { z = -1f; }
        if (Keyboard.current.aKey.isPressed) { x = -1f; }
        if (Keyboard.current.dKey.isPressed) { x = 1f; }

        // Forward and right are the way I'm facing
        Vector3 move = (transform.forward * z + transform.right * x) * currentSpeed;

        // I set my speed sideways and forward. Gravity keeps up and down.
        body.linearVelocity = new Vector3(move.x, body.linearVelocity.y, move.z);

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}


