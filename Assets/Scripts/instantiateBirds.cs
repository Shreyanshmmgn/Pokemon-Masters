using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateBirds : MonoBehaviour
{
    public Rigidbody2D enemies;
    [SerializeField] Transform[] pos;
    void Start()
    {
        //    StartCoroutine(DoCheck());
        InvokeRepeating("inst", 0f, 5f);
    }
    public void inst()
    {
        
        Vector2 speed = new Vector2(1, 0);
        int r = Random.Range(0, pos.Length);
        Vector2 position = pos[r].position;

        
        Rigidbody2D clone = Instantiate(enemies, position, transform.rotation);
        clone.velocity = new Vector2(-2, 0);
    }
}
