using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectables : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(gameObject.tag=="Pokeball")Destroy(gameObject);
        }
        else if (other.CompareTag("Pokemon"))
        {
            if(gameObject.tag=="Crystal")Destroy(gameObject);
        }
    }
}
