using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Door : MonoBehaviour
{
    public const int Idle = 0;
    public const int Opening = 0;
    public const int Open = 0;
    public const int Closing = 0;
    private int state = Idle;
    private Animator animator;
    public float closeDelay = 0.5f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }
    public void onOpenStart()
    {
        state = Opening;
    }
    public void onOpenEnd()
    {
        state = Open;
    }
    public void onCloseStart()
    {
        state = Closing;
    }
    public void onCloseEnd()
    {
        state = Idle;
    }
    public void dissableCollider2D()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
    }
    public void enableCollider2D()
    {
        gameObject.GetComponent<Collider2D>().enabled = true;
    }
    public void Close()
    {
        StartCoroutine(closeNow());
    }
    public void open()
    {
        animator.SetInteger("animState",1);
    }
    private IEnumerator closeNow()
    {
        yield return new WaitForSeconds(closeDelay);
        animator.SetInteger("animState", 2);
    }
}
