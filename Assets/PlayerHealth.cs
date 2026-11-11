using UnityEngine;
using Unity.Collections;

public class PlayerHealth : MonoBehaviour
{
    //variables for the player health
    public int health;
    public int maxHealth = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth; //so that you are at full health at start 
       
    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Destroy(gameObject);
            RespawnPlayer();
        }
    }

    void RespawnPlayer()
    {
        health = maxHealth;
    }

}
