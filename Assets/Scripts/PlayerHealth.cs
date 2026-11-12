using UnityEngine;
using Unity.Collections;

public class PlayerHealth : MonoBehaviour
{
    //variables for the player health
    public int health;
    public int maxHealth = 3;
    public PlayerRespawn playerRespawnScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth; //so that you are at full health at start 

    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            if (playerRespawnScript != null)
            {
                playerRespawnScript.Respawn();
            }
            health = maxHealth;
        }
        //referencing the player respawn script and the respawn function in it, if health is less or requal to zero then respawn with full health
        //referencing the player respawn script and the respawn function in it, if health is less or requal to zero then respawn with full health

    }
}
