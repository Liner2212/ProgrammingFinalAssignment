using UnityEngine;

public class SlimeStomp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //For the slime stomp, if the slime with the tag weakpoint is detected by the collider then destroy the slime
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "WeakPoint")
        { 
            Destroy(collision.gameObject);
        }
    }
}
