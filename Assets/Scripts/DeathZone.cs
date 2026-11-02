using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public PlayerRespawn player;

    void OnTriggerEnter(Collider other)
    {
        // Something walked into me, so I'm asking the player to respawn
        player.Respawn();
    }
}


