using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove2D : MonoBehaviour
{
    public Rigidbody2D body;
    public float moveSpeed = 5f;
    public float jumpSpeed = 7f;

    void Update()
    {
        float x = 0f;
        if (Keyboard.current.aKey.isPressed) { x = -1f; }
        if (Keyboard.current.dKey.isPressed) { x = 1f; }

        // Left and right come from me. Up and down I leave alone, so gravity still works.
        body.linearVelocity = new Vector2(x * moveSpeed, body.linearVelocity.y);

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Jump: keep my sideways speed, shoot me upward
            body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
        }
        if (Keyboard.current.leftShiftKey.isPressed)
        {
            //I want to make the plyer move faster when holding down the left shift key
            body.linearVelocity = new Vector2(x * moveSpeed * 2, body.linearVelocity.y);
            //took the same from before in the script, times 2 to make it move faster
        }
    }
}
