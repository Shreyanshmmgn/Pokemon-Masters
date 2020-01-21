using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplaySceneThree : MonoBehaviour
{
    public Animator[] animator;

    public int chance = -1;
    private void Start()
    {
        // animator = GetComponent<Animator>();
    }

    private void Update()
    {
        chance = Random.Range(0, animator.Length);

        animator[2].SetInteger("spike3", 0);
        animator[1].SetInteger("spike2", 0);
        animator[0].SetInteger("spike1", 0);

        InvokeRepeating("setBacktozero", .5f, 10);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

    }
    public void setBacktozero()
    {

        if (chance == 0)
        {
            animator[chance].SetInteger("spike1", 1);
        }
        else if (chance == 1)
        {
            animator[chance].SetInteger("spike2", 1);
        }
        else
        {
            animator[chance].SetInteger("spike3", 1);
        }
        
    }
}
