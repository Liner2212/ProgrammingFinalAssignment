using UnityEngine;

public class DeathZone : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerRespawn player = other.GetComponent<PlayerRespawn>(); //recalling my respawn script
        if (player != null)
        {
            player.Respawn();
        }//checking if its on the object that enters the trigger area, to be able to invoke the cannon prefab i had to change it because it wouldnt let me drag my player into the slot

    }
}


