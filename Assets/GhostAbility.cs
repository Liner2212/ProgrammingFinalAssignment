using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class GhostAbility : MonoBehaviour
{
    private GameObject[] ghostWalls;
    private SpriteRenderer spriterenderer;


    void Start()

    {//find the tag 
        ghostWalls = GameObject.FindGameObjectsWithTag("GhostWall");
       
    }

    private void Update()  //when G is pressed and for each ghost wall item, if holding g, inactive and if released g its active
    {
        bool isHoldingDownG = Keyboard.current.gKey.isPressed; //true or false statement

        foreach (GameObject wall in ghostWalls)
        {
            //get the sprite renderer and then if holding G 
            spriterenderer = wall.GetComponent<SpriteRenderer>();

            if (spriterenderer != null)
            {
                spriterenderer.enabled = !isHoldingDownG;
            }
            
        }
    }
}