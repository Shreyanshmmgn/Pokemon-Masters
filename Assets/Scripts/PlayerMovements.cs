using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public TrackPokeballCount trackPokeball;
    public int pokeball = 0;

    public float speed = 10.0f;
    public Rigidbody2D rb;
    public bool isGrounded = false;
    public bool standing;
    public float jumpForce = 10.0f;

    // private playerController controller;    
    public Vector2 maxSpeed = new Vector2(3, 0);

    private Animator animator;


    void Start()
    {
        // controller = GetComponent<playerController>();
        animator = GetComponent<Animator>();
        pokeball = PlayerPrefs.GetInt("pokeballCount");
        Debug.Log("Inside Start -  - " + pokeball);
        // GameObject track = GetComponent<GameObject>();
        // trackPokeball = track.GetComponent<TrackPokeballCount>();
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
            transform.localScale = new Vector3(1f, 1f, 1f);
            animator.SetInteger("animState", 1);

        }
        else if (Input.GetKey("left"))
        {
            if (absVelx < maxSpeed.x)
            {
                forceX = -speed;
            }
            transform.localScale = new Vector3(-1f, 1f, 1f);
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Pokeball"))
        {
            pokeball += 1;
            // trackPokeball.getpokeballCount();
            PlayerPrefs.SetInt("pokeballCount", pokeball);
            Debug.Log("pokeballCount Count -- " + pokeball);
            Debug.Log(PlayerPrefs.GetInt("pokeballCount"));

        }
    }

}
