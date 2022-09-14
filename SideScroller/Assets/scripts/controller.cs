using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    //stores reference to rigidbody
    private Rigidbody2D rBody;
    private Animator anim;

    //movement speed
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce = 0f;
    private float moveX = 0f;

    [SerializeField] private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        //store core refs
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() //-movements here
    {
        //movement input check
        if (isGrounded == true) //Once you jump you jumped.
        { 
            moveX = Input.GetAxis("Horizontal"); //variable left or right
        }

        //flips character direction
        if (moveX >= 0.1 && isGrounded == true) //stops direction change mid jump
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (moveX <= -0.1 && isGrounded == true)
        {
            transform.localScale = Vector2.one;
        }


        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            Jump();    
        }

        //animations
        anim.SetBool("Run", moveX != 0);
        anim.SetBool("isGrounded", isGrounded);

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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

   


}


