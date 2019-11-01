using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class righttoleft : MonoBehaviour
{
    public cameraMovement camera2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            camera2.newPosition2();
        }
    }
}
