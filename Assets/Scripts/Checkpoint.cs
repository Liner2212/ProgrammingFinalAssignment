using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public PlayerRespawn player;

    void OnTriggerEnter(Collider other)
    {        
        // The player reached me, so this is the new place to come back to
        player.SetCheckpoint(transform.position);
    }
}

