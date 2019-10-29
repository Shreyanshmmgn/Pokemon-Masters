using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovements player;
    public pokemonMovements pokemon;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            player.isGrounded = true;
            pokemon.grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            player.isGrounded = false;
            pokemon.grounded = false;
        }
    }
}
