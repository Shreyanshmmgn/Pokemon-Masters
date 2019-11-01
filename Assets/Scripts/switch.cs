using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public doorTrigger[] doorTriggers;
    private Animator animator;
    public bool sticky;
    private bool down;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        animator.SetInteger("animState", 1);
        down = true;
        foreach (doorTrigger trigger in doorTriggers)
        {
            if (trigger != null)
            {
                trigger.Toggle(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (sticky && down) return;
        animator.SetInteger("animState", 2);
        down = false;
        foreach (doorTrigger trigger in doorTriggers)
        {
            if (trigger != null)
            {
                trigger.Toggle(false);
            }
        }
    }
    private void OnDrawGizmos() {
        Gizmos.color = sticky ? Color.red : Color.green;
        foreach(doorTrigger trigger in doorTriggers)
        {
            if(trigger != null)
            {
                Gizmos.DrawLine(transform.position, trigger.door.transform.position);
            }
        }
    }
}
