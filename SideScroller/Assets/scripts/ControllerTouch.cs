using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchControlsKit;

public class ControllerTouch : MonoBehaviour
{
    //stores reference to rigidbody
    private Rigidbody2D rBody;
    private Animator anim;
    private CapsuleCollider2D capsColl2D; //

    //movement speed
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce = 0f;
    private float moveX = 0f;

    public LayerMask groundLayer;

    private bool isGrounded;
    private bool Fall;



    // Start is called before the first frame update
    void Start()
    {
        //store core refs
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        capsColl2D = GetComponent<CapsuleCollider2D>(); //
        Time.timeScale = 1f;
    }


    void Update() //-movements here
    {
        IsFalling();


        //movement input check
        if (isGrounded == true) //Once you jump you jumped.
        {
            moveX = TCKInput.GetAxis("Joystick", EAxisType.Horizontal); //variable left or right
            IsGrounded();
        }

        //flips character direction
        if (moveX >= 0.1 && IsGrounded()) //stops direction change mid jump //isGrounded == true
        {
            transform.localScale = new Vector3(1, 1, 1); //(-1, 1, 1); for pig/swapped.
        }
        else if (moveX <= -0.1 && IsGrounded())
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


        //jump
        if (TCKInput.GetAction("jumpBtn", EActionEvent.Down) && isGrounded == true)
        {
            Jump();
        }

        //animations////////////////////////////////////////////////////////////
        anim.SetBool("Run", moveX != 0);
        anim.SetBool("isGrounded", isGrounded);
        anim.SetBool("isFalling", IsFalling());


    }

    private void FixedUpdate() //regular update depends on speed of computer. FixedUpdate is consistent. //-calculations of movements here
    {
        //movement calculations!
        //horizontal movement
        rBody.velocity = new Vector2(moveX * moveSpeed, rBody.velocity.y);


    }

    private void Jump()
    {
        rBody.velocity = new Vector2(rBody.velocity.x, jumpForce);
        isGrounded = false;
        anim.SetTrigger("JumpTrigger"); //triggers jump animation
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(capsColl2D.bounds.center, capsColl2D.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

    private bool IsFalling()
    {
        if (rBody.velocity.y <= -0.5f && !IsGrounded())
        { return true; }
        else { return false; }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }




}


