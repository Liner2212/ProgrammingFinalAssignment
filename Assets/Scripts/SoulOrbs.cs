using UnityEngine;

public class SoulOrbs
    : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
        //2D to make it work in the scene, It took me way too long to realize this I kept missing it
    {
        // Referncing the player diamonds script

        PlayerSoulOrbs wallet = other.GetComponent<PlayerSoulOrbs>();

        if (wallet != null)
        {
            wallet.AddSoulOrbs();
            Destroy(gameObject);
        }
    }
}
