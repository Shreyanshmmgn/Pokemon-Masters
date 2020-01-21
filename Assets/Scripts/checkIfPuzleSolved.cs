using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class checkIfPuzleSolved : MonoBehaviour
{

    [SerializeField] private Transform[] Images;
    // private GameObject winText;
    [SerializeField] public bool allRight;
    // private
    void Update()
    {
        if (Images[0].rotation.z == 0 &&
            Images[1].rotation.z == 0 &&
            Images[2].rotation.z == 0 &&
            Images[3].rotation.z == 0 &&
            Images[4].rotation.z == 0 &&
            Images[5].rotation.z == 0 &&
            Images[6].rotation.z == 0 &&
            Images[7].rotation.z == 0
            )
        {
            allRight = true;
            SceneManager.LoadScene("Win");
        }
    }
}
