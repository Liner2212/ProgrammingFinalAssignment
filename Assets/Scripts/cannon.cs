using UnityEngine;

public class cannon : MonoBehaviour

    
{
    public GameObject cannonball;
    public float fireRate = 1; //seconds
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Shoot", 0f, fireRate); //start shooting, also repeating so it keeps going
    }

    // Update is called once per frame
    void Shoot()
    {
        if (cannonball != null)
        {
            Instantiate(cannonball, transform.position, transform.rotation);
        }
    }
}
