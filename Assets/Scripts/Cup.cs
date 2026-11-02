using UnityEngine;
using UnityEngine.SceneManagement;  
using System.Collections;
using UnityEngine.UI;
using UnityEditor;
using System.Collections.Generic;
using Unity.Hierarchy;

public class Cup : MonoBehaviour
{
    public Rigidbody ball;
    bool holed = false;
    public PlayerRespawn player;

    public Canvas Canvas;
    void OnTriggerStay(Collider other)
    {
        // Only counts if the ball has nearly stopped inside me
        if (ball.linearVelocity.magnitude < 0.5f) { holed = true; }

        


        WaitForSeconds wait = new WaitForSeconds(5); Canvas.GetComponent<Canvas>().enabled = true;


        



    }


        void OnGUI()
        {
            if (holed) { GUI.Label(new Rect(100, 160, 600, 80), "You made it!"); }
         GUI.Label(new Rect(100, 200, 600, 80), "Press R to restart");
    }
    }


