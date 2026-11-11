using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove2D : MonoBehaviour
{
    public Rigidbody2D body;
    public float moveSpeed = 5f;
    public float jumpSpeed = 7f;

    //for sprite flip
    public SpriteRenderer spriteRenderer;

    public bool isGrounded;
    //player is grounded check, bool is yes or no
    public float checkRadius;
    //The radius that will check for the ground and if the player is on it
    public LayerMask Ground;
    //the layer all of the ground is one, so when it checks it will scan these
    public Transform checkGround;
    //check the ground, transform is the position 

    public int JumpCount = 2; 
    //the number of jumps the player can do, adding in the double jump
    public int resetJumpCount;
       void Start()
    { //get my player sprite
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();
    }



    void Update() //
    {
        float x = 0f;
        if (Keyboard.current.aKey.isPressed) { x = -1f; }
        if (Keyboard.current.dKey.isPressed) { x = 1f; }

        // Left and right come from me. Up and down I leave alone, so gravity still works.
        body.linearVelocity = new Vector2(x * moveSpeed, body.linearVelocity.y);

        isGrounded = Physics2D.OverlapCircle(checkGround.position, checkRadius, Ground);
        //okay so, I watched videos on this, the script here as i understand is that isGrounded is defined by checking if the physics2D overlap circle is touching the ground
        //the checkground.position is to check the position of the player, then check the radius and if the ground is within that

        if (x > 0) //handle flipping, if x is greater than 0 then no flipping, and vice versa
            {
            spriteRenderer.flipX = false; 

        }
        if (x < 0)
        {  spriteRenderer.flipX = true;}
        

        if (Keyboard.current.spaceKey.wasPressedThisFrame && JumpCount > 0) //checks if space is pressed and the isgrounded to check that the player is also in the ground, no more float fly away to infinity
        {
            Debug.Log("Space was pressed");
            body.linearVelocity = new Vector2(body.linearVelocity.x, jumpSpeed);
            JumpCount--; //decrease the jump count by 1 each time space is pressed and in the air. 
        }
        if (isGrounded) JumpCount = resetJumpCount;
        Debug.Log("jumpcounted");
        //I want to make it so if the player is grounded the jump counter resets back again

        if (Keyboard.current.leftShiftKey.isPressed)
        {
            //I want to make the plyer move faster when holding down the left shift key
            body.linearVelocity = new Vector2(x * moveSpeed * 2, body.linearVelocity.y);
            //took the same from before in the script, times 2 to make it move faster
        }
    }



}
