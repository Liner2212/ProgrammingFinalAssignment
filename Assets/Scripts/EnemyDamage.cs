using UnityEngine;
//I want to make the enemy damage script so that my player can get affected by the enemies and instead of instant death, they lose a heart. Lava is still unavoidable death however the goal is to have it so if the player enters their collider then they damage. 
public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 1;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) //if the game object tagged player collides then damage will be dealt. 
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
