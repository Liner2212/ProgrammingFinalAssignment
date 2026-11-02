using UnityEngine;
using UnityEngine.InputSystem;

// Demo of how a camera FoV change can help increase the "juice" of a mechanic
// Setup: a Capsule called Player with this script (instead of PlayerMove),
// Main Camera dragged onto Player and placed above and behind (0, 3, -6, rotation 20, 0, 0),
// then Main Camera dragged into the Cam slot.
// While playing: hold Shift to sprint, press J to switch the juice off and on.
public class PlayerMoveJuiceDemo : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float sprintSpeed = 7f;
    public Camera cam;

    // The only difference between Version 1 and Version 2
    public bool juiceOn = false;
    public float walkFov = 60f;
    public float sprintFov = 75f;

    // How quickly the view eases towards its target. Higher is snappier.
    public float fovSpeed = 6f;

    void Update()
    {
        // J flips the juice on and off, so I don't have to click the Inspector mid-demo
        if (Keyboard.current.jKey.wasPressedThisFrame)
        {
            juiceOn = !juiceOn;
        }

        float currentSpeed;
        float targetFov = walkFov;
        if (Keyboard.current.leftShiftKey.isPressed)
        {
            // The speed is the same in both versions
            currentSpeed = sprintSpeed;

            if (juiceOn)
            {
                targetFov = sprintFov;
            }
        }
        else
        {
            currentSpeed = moveSpeed;
        }

        // Ease part of the way towards the target every frame, instead of popping
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, targetFov, fovSpeed * Time.deltaTime);

        float step = currentSpeed * Time.deltaTime;

        if (Keyboard.current.wKey.isPressed) { transform.Translate(0, 0, step); }
        if (Keyboard.current.sKey.isPressed) { transform.Translate(0, 0, -step); }
        if (Keyboard.current.aKey.isPressed) { transform.Translate(-step, 0, 0); }
        if (Keyboard.current.dKey.isPressed) { transform.Translate(step, 0, 0); }

        // Back to the start if I run off the far edge, so the demo can keep going
        if (transform.position.z > 20)
        {
            transform.position = new Vector3(0, 1, 0);
        }
    }

    // A big label so you know which version you're looking at
    void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.label);
        style.fontSize = 36;
        style.normal.textColor = Color.yellow;

        if (juiceOn)
        {
            GUI.Label(new Rect(30, 20, 800, 60), "Version 2: sprint + wider view", style);
        }
        else
        {
            GUI.Label(new Rect(30, 20, 800, 60), "Version 1: sprint only", style);
        }
    }
}