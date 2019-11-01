using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyovement : MonoBehaviour
{
    public float speed = 0.5f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(transform.localScale.x, 0) * speed;
    }
}
