using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateChanigingColliders : MonoBehaviour
{
    public GameObject gOb1,gob2;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            gob2.SetActive(true);
            gOb1.SetActive(false);
        }
    }
}
