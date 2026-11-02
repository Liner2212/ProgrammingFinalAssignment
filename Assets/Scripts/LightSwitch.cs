using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class LightSwitch : MonoBehaviour
{
    public Light[] lamps;

    void Update()
    {
        if (Keyboard.current.lKey.wasPressedThisFrame)
        {
            // I'm doing the same thing to every lamp in the list
            foreach (Light lamp in lamps)
            {
                if (lamp.enabled)
                {
                    lamp.enabled = false;
                }
                else
                {
                    lamp.enabled = true;
                }
            }
        }

    }
}
