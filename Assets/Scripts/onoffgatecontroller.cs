using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffgatecontroller : MonoBehaviour
{
   public GameObject gOb1,gob2;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            gOb1.SetActive(true);
            gob2.SetActive(false);
        }
    }
}
