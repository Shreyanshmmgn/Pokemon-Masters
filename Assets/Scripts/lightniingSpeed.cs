using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightniingSpeed : MonoBehaviour
{
    public GameObject destroyEffect;
    public float velocityLightning = 3;
    public float lifetime = 2;

    public Rigidbody2D rb;
    void Start()
    {
        Invoke("destroyLight", lifetime);
    }
    private void Update()
    {
        rb.velocity = new Vector3(velocityLightning, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            GameObject clone = Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(clone, 1f);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Chain"))
        {
            GameObject clone = Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(clone, 1f);
            other.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
    void destroyLight()
    {

        Destroy(gameObject);

    }
    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     if (other.gameObject.tag == "Charizard")
    //     {
    //         Destroy(gameObject);
    //     }

    // }
}
