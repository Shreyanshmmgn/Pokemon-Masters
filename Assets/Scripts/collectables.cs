using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class collectables : MonoBehaviour
{
    public scoreScript scoreScript;

    public bool checkCollectableCollected = false;

    private void Start()
    {
        if(checkCollectableCollected)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.tag == "Crystal")
            {
                //Nothing will happen
            }
            else
            {

                scoreScript.scoreVale += 100;
                if (gameObject.tag == "Pokeball") Destroy(gameObject);


            }
        }
        else if (other.CompareTag("Pokemon") | other.CompareTag("Charizard"))
        {
            if (gameObject.tag == "Pokeball")
            {
                //Nothing will happen
            }
            else
            {
                scoreScript.scoreVale += 5;
                if (gameObject.tag == "Crystal") Destroy(gameObject);

            }
        }
    }
}
