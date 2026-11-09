using Unity.VisualScripting;
using UnityEngine;

public class Goal : MonoBehaviour
{
    bool reached = false;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        // The player made it
        reached = true;
    }

    void OnGUI()
    {
        //bigger font, new font 
         GUIStyle myStyle = new GUIStyle(GUI.skin.label);
        myStyle.fontSize = 64;
        if (reached)
        {
            GUI.Label(new Rect(100, 100, 600, 150), "You reached the end so far!", myStyle);
        }
    }
}
