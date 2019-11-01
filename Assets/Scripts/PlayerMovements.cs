using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody2D rb;
    public bool isGrounded = false;
    public bool standing;
    public float jumpForce = 10.0f;

    // private playerController controller;    
    public Vector2 maxSpeed = new Vector2(3, 0);

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        // controller = GetComponent<playerController>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        var forceX = 0f;
        // to reset the force each frame
        // weteher thr player is moving faster or not
        var absVelx = Mathf.Abs(rb.velocity.x);

        if (Input.GetKey("right"))
        {
            if (absVelx < maxSpeed.x)
            {
                forceX = speed;
            }
            transform.localScale = new Vector3(6.405936f, 6.405936f, 6.405936f);
            animator.SetInteger("animState", 1);

        }
        else if (Input.GetKey("left"))
        {
            if (absVelx < maxSpeed.x)
            {
                forceX = -speed;
            }
            transform.localScale = new Vector3(-6.405936f, 6.405936f, 6.405936f);
            animator.SetInteger("animState", 1);
        }
        else
        {
            animator.SetInteger("animState", 0);
        }

        rb.AddForce(new Vector2(forceX, 0));
        bool v = Input.GetKeyDown("up") && isGrounded == true;
        if (v)
        {
            rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
  

    }
    // public void giveChild()
    // {
    //     GameObject ChildGameObject1 = gameObject.transform.GetChild(0).gameObject;
    // }



}
