using UnityEngine;

public class Diamond : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
        //2D to make it work in the scene, It took me way too long to realize this I kept missing it
    {
        // Referncing the player diamonds script

        PlayerDiamonds wallet = other.GetComponent<PlayerDiamonds>();

        if (wallet != null)
        {
            wallet.AddDiamonds();
            Destroy(gameObject);
        }
    }
}
