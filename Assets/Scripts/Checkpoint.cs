using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public PlayerRespawn player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // The player reached me, so this is the new place to come back to
        Debug.Log("Checkpoint reached!");  //debug log
        player.SetCheckpoint(transform.position);
    }

}

