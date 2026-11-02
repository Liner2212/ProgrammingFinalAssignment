using UnityEngine;
using UnityEngine.InputSystem;

public class PuttBall : MonoBehaviour


{
    public Rigidbody body;
    public float maxPower = 12f;    // the hardest putt
    public float chargeTime = 1.2f; // seconds to reach full power
    public int strokesLeft = 4;
    public float power = 0f;               // how hard, right now

    public float jumpForce = 5f;


    void Update()
    {
        if (strokesLeft > 0)
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                power = power + maxPower /  chargeTime * Time.deltaTime;
                if (power > maxPower) { power = maxPower; }
            }

            if (Keyboard.current.spaceKey.wasReleasedThisFrame)
            {
                // I'm putting the ball
                body.AddForce(Vector3.forward * power, ForceMode.Impulse);
                strokesLeft = strokesLeft - 1;
                power = 0f;
            }
        }

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            // Reset the ball to the starting position
            transform.position = new Vector3(0, 0.02f, -8);
            
        }


    }
    void OnGUI()
    {
        // Feedback: the player can see their strokes and their power
        GUI.Label(new Rect(20, 20, 300, 40), "Strokes left: " + strokesLeft);
        GUI.Label(new Rect(20, 50, 300, 40), "Power: " + power);
    }
}





