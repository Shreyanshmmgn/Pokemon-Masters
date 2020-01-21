using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokemonMovements : MonoBehaviour
{
    //Refrences
    private Animator animator;
    Rigidbody2D rb, clone;

    public Rigidbody2D lightning, lightning2;
    [SerializeField] Transform pos;

    //Bolleans
    public bool grounded = false;
    public bool doubleJump = false;

    private bool facingRight = true;

    bool v;

    //Float Variables
    public float jumpForce = 5.0f;
    public float speed = 10.0f;
    public float speedCharizard = 0;

    float forceX;
    float absVelx;
    private float timeBtwShots;
    public float startTimeBtwShots;

    //Vectors 
    public Vector2 maxSpeed = new Vector2(3, 0);

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        //Moving Animations WHAT TO DO IF i WANNA SAME SCRIPT FOR CHARIZARD-- HOW TO REMOVE REDUNDANCYS
        //==============================================================================================================================================
        if (Input.GetKey("d"))
        {
            if (absVelx < maxSpeed.x)
            {
                forceX = speed;
            }
            transform.localScale = new Vector3(1f, 1f, 1f);
            if (gameObject.tag == "Pokemon")
            {
                animator.SetInteger("animPikachu", 1);

            }
            else if (gameObject.tag == "Charizard")
            {
                animator.SetInteger("animCharizard", 1);

            }
            facingRight = true;
        }
        else if (Input.GetKey("a"))
        {
            if (absVelx < maxSpeed.x)
            {
                forceX = -speed;
            }
            transform.localScale = new Vector3(-1f, 1f, 1f);
            if (gameObject.tag == "Pokemon")
            {
                animator.SetInteger("animPikachu", 1);

            }
            else if (gameObject.tag == "Charizard")
            {
                animator.SetInteger("animCharizard", 1);

            }
            facingRight = false;
        }
        else if (Input.GetKey("w") | Input.GetKey("s"))
        {
            if (gameObject.tag == "Charizard")
            {
                animator.SetInteger("animCharizard", 1);
            }
        }
        else
        {
            if (gameObject.tag == "Pokemon")
            {
                animator.SetInteger("animPikachu", 0);

            }
            else if (gameObject.tag == "Charizard")
            {
                animator.SetInteger("animCharizard", 0);
            }
        }
        //==============================================================================================================================================
        // Attack animation
        //==============================================================================================================================================
        if (gameObject.tag == "Pokemon")
        {
            if (Input.GetKey("q"))
            {
                Vector3 finalPosition = pos.position;
                if (facingRight)
                {

                    if (timeBtwShots <= 0)
                    {
                        clone = Instantiate(lightning, finalPosition, Quaternion.identity);
                        timeBtwShots = startTimeBtwShots;
                    }
                    else
                    {
                        timeBtwShots -= Time.deltaTime;
                    }
                }
                else
                {
                    Debug.Log("Facing Left");
                    if (timeBtwShots <= 0)
                    {
                        clone = Instantiate(lightning2, finalPosition, Quaternion.identity);
                        timeBtwShots = startTimeBtwShots;
                    }
                    else
                    {
                        timeBtwShots -= Time.deltaTime;
                    }
                }


                // animator.SetInteger("an  public float velocityLightning = 3;imPikachu", 2);   

            }
            // else if (Input.GetKey("e"))
            // {
            //     if (gameObject.tag == "Pokemon")
            //     {
            //         animator.SetInteger("animPikachu", 3);
            //     }
            // }

        }

    }

    // private void OnCollisionEnter2D(Collision2D other)
    // {

    //     if (other.gameObject.tag == "Charizard")
    //     {   print("Charizard collision detected");
    //         animator.SetInteger("animPikachu", 5);
    //         // onExplode();
    //     }
    // }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(forceX, 0));
        if (gameObject.tag == "Pokemon")
        {

            if (v)
            {
                if (grounded)
                {
                    animator.SetInteger("animPikachu", 4);
                    rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                    doubleJump = true;
                }
                else
                {
                    if (doubleJump)
                    {
                        doubleJump = false;
                        rb.velocity = new Vector2(rb.velocity.x, 0);
                        // resting y velocity
                        rb.AddForce(new Vector2(0, jumpForce / 1.25f), ForceMode2D.Impulse);
                    }
                }
            }
        }
        else if (gameObject.tag == "Charizard")
        {
            if (Input.GetKey("w"))
            {
                rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode2D.Force);
                if (facingRight)
                {
                    rb.AddForce(new Vector2(speedCharizard, 0));
                }
                else
                {
                    rb.AddForce(new Vector2(-speedCharizard, 0));
                }
            }
            else if (Input.GetKey("s"))
            {
                rb.AddForce(new Vector3(0, -jumpForce / 4, 0), ForceMode2D.Force);

            }
        }

    }
}
