using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotataionImage : MonoBehaviour
{
    public checkIfPuzleSolved check;
    void OnMouseDown()
    {   
        if (!check.allRight)
        {
            transform.Rotate(0f, 0f, 90f);
        }
    }
}
