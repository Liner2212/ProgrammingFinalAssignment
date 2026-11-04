using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform spawnPoint;
    public Rigidbody2D body;    

    public void Respawn()
    {
        // I'm going back to my spawn point
        transform.position = spawnPoint.position;
        Debug.Log(body.linearVelocity);

        //stop moving
        body.linearVelocity = Vector2.zero;
    }
    public void SetCheckpoint(Vector3 position)
    {
        // From now on, I come back here
        spawnPoint.position = position;

      
    }

}

