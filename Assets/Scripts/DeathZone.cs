using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public PlayerRespawn player;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Something walked into me, so I'm asking the player to respawn
        player.Respawn();
    }
}


