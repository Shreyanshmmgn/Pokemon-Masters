using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lookingForward : MonoBehaviour
{
    public Transform sightStart, sightEnd;
    public bool needCollision = true;
    private bool collision = false;

    [SerializeField] Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        animator.SetInteger("animCharizard", 1);
        collision = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Solid"));
        Debug.DrawLine(sightStart.position, sightEnd.position, Color.green);
        if (collision == needCollision)
        {
            this.transform.localScale = new Vector3((transform.localScale.x == 1.682797f) ? -1.682797f : 1.682797f, 1.682797f, 1.682797f);
        }
    }
}
