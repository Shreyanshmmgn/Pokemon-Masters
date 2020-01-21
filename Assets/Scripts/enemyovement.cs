using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyovement : MonoBehaviour
{
    public GameObject destroyEffect;
    public int deadlyCount = 0;
    public float speed = 0.5f;
    public Rigidbody2D rb;
    void Update()
    {
        rb.velocity = new Vector2(transform.localScale.x, 0) * speed;
    }
    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     if (other.gameObject.tag == "Lightning")
    //     {
    //         deadlyCount += 1;
    //         if (deadlyCount > 3)
    //         {
    //             GameObject clone = Instantiate(destroyEffect, transform.position, Quaternion.identity);
    //             Destroy(clone, 1f);
    //             Destroy(gameObject, 1f);

    //         }
    //         Destroy(other.gameObject);

    //     }

    // }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Lightning"))
        {
            deadlyCount += 1;
            if (deadlyCount > 3)
            {
                GameObject clone = Instantiate(destroyEffect, transform.position, Quaternion.identity);
                Destroy(clone, 1f);
                Destroy(gameObject, 1f);

            }
            Destroy(other.gameObject);

        }
    }

}

