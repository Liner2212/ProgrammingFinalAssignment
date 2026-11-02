using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public float sightRange = 6f;
    public Light WarningLight;
    public float warnRange = 10f;

    void Update()
    {
        // Every frame: walk to wherever the player is right now
        if (IsPlayerClose())
            
        {
            agent.SetDestination(player.position);
        }
    }
   
    // A question: is the player close? Yes or no.
    bool IsPlayerClose()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        return distance < sightRange;
    }
    bool IsPlayerNear()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        return distance < warnRange;
    }


    void OnDrawGizmos()
    {
        // Show my sight range in the Scene view
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, sightRange);
        //Warning light ring
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, warnRange);
       
    }

    private void OnGUI()
    {
        GUI.skin.label.fontSize = 32;
        if (IsPlayerClose())
        {
            GUI.Label(new Rect(20, 80, 300, 40), " They can see you!");
        }
        else if (IsPlayerNear())
        {
            GUI.Label(new Rect(20, 120, 300, 40), "They are watching");
        }
       
       
    }

}
