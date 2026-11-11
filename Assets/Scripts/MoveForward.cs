using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 0.1f;
    public float size = 1f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = new Vector3(size, size, size);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Speed is: " + speed);  //debug log 
        transform.Translate(Vector3.right * speed * Time.deltaTime); //so it is fair for slower and faster computers, then times speed and also vector3.right because the cannonballs will go to the right
    }
}
