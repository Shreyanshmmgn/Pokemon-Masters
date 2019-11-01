using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded_for_pikachu : MonoBehaviour
{
    // Start is called before the first frame update
    public pokemonMovements pokemon;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            pokemon.grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {

            pokemon.grounded = false;
        }
    }
}
