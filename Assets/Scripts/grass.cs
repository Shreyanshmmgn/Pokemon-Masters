using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            animator.SetTrigger("move");
        }    
    }
}
