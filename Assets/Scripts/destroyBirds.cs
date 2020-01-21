﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBirds : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bird")
        {
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            Destroy(other.gameObject);

        }
    }
}
