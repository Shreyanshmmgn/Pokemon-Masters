using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokemonMovements : MonoBehaviour
{
    //Refrences
    private Animator animator;
    public Rigidbody2D rb;

    //Bolleans
    public bool grounded = false;
    public bool doubleJump = false;

    bool v;

    //Float Variables
    public float jumpForce = 5.0f;
    public float speed = 10.0f;

    float forceX;
    float absVelx;

    //Vectors 
    public Vector2 maxSpeed = new Vector2(3, 0);

    void Start()
    {
        // controller = GetComponent<playerController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        forceX = 0f;
        absVelx = Mathf.Abs(rb.velocity.x);
        v = Input.GetKeyDown("w");
        //==============================================================================================================================================
        //Moving Animations
        //==============================================================================================================================================
        if (Input.GetKey("d"))
        {
            if (absVelx < maxSpeed.x)
            {
                forceX = speed;
            }
            transform.localScale = new Vector3(1.605f, 1.605f, 1.605f);
            animator.SetInteger("animPikachu", 1);
        }
        else if (Input.GetKey("a"))
        {
            if (absVelx < maxSpeed.x)
            {
                forceX = -speed;
            }
            transform.localScale = new Vector3(-1.605f, 1.605f, 1.605f);
            animator.SetInteger("animPikachu", 1);
        }
        else
        {
            animator.SetInteger("animPikachu", 0);

        }
        //==============================================================================================================================================
        // Attack animation
        //==============================================================================================================================================
        if (Input.GetKey("q"))
        {
            animator.SetInteger("animPikachu", 2);
        }
        else if (Input.GetKey("e"))
        {
            animator.SetInteger("animPikachu", 3);
        }
        //==============================================================================================================================================
        // Jump animation
        //==============================================================================================================================================
        if (Input.GetKey("w"))
        {
            animator.SetInteger("animPikachu", 4);

        }


    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(forceX, 0));

        if (v)
        {
            if (grounded)
            {
                rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                doubleJump = true;
            }
            else
            {
                if(doubleJump)
                {
                    doubleJump = false;
                    rb.velocity = new Vector2(rb.velocity.x,0);
                    // resting y velocity
                    rb.AddForce(new Vector2(0,jumpForce/1.25f), ForceMode2D.Impulse);
                }
            }
        }
    }
}
