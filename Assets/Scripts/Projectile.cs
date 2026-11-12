using UnityEngine;
using UnityEngine.InputSystem;

public class Projectile : MonoBehaviour

    
{
    public GameObject projectile;
    public float fireRate = 1; //seconds
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
  

    // Update is called once per frame
    void Shoot()
    {
        if (Keyboard.current.eKey.isPressed)
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
