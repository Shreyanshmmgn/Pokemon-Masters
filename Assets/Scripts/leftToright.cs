using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftToright : MonoBehaviour
{   public cameraMovement camera1;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {   
            camera1.newPosition();
        }
    }
    // private void OnCollisionEnter2D(Collision2D other) {

    //     if(other.gameObject.tag=="Player")
    //     {   print("Player hit move camera");
    //         camera1.newPosition();
    //     }
    // }
}
