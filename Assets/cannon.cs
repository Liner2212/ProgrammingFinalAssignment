using UnityEngine;

public class cannon : MonoBehaviour

    
{
    public GameObject cannonball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(cannonball, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cannonball, transform.position, transform.rotation);
    }
}
