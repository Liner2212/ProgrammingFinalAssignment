using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove_Old : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    public float sprintSpeed = 7f;
    public float currentSpeed;

    public Camera cam;

    void Update()
    {
        // First, I'm deciding how fast to go this frame
        if (Keyboard.current.leftShiftKey.isPressed)
        {
            currentSpeed = sprintSpeed;
            cam.fieldOfView = 75;
        }
        else
        {
            currentSpeed = moveSpeed;
            cam.fieldOfView = 60;
        }
        // Then I'm working out how far to move this frame
        float step = currentSpeed * Time.deltaTime;

        if (Keyboard.current.wKey.isPressed) { transform.Translate(0, 0, step); }
        if (Keyboard.current.sKey.isPressed) { transform.Translate(0, 0, -step); }
        if (Keyboard.current.aKey.isPressed) { transform.Translate(-step, 0, 0); }
        if (Keyboard.current.dKey.isPressed) { transform.Translate(step, 0, 0); }

        // I walked off the far edge, so I'm going back to the start
        if (transform.position.z > 20)
        {
            transform.position = new Vector3(0, 1, 0);
        }

    }
}

