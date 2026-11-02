using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform spawnPoint;

    public void Respawn()
    {
        // I'm going back to my spawn point
        transform.position = spawnPoint.position;
    }
    public void SetCheckpoint(Vector3 position)
    {
        // From now on, I come back here
        spawnPoint.position = position;
    }

}

