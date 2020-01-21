using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplaySceneOne : MonoBehaviour
{ //    [SerializeField] Animator charizardASh;
    private Animator animator;
    private GameObject clone;
    // [SerializeField] Transform ash;
    // [SerializeField] Transform charizardAsh;
    [SerializeField] GameObject game_1;
    [SerializeField] Transform transform1;
    private BoxCollider2D box;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pokemon"))
        {
            animator.SetInteger("animSpike", 1);
        }
    }

    public void restart_scene_from_current_position()
    {
        animator.SetInteger("animSpike", 0);
        box.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKey("h"))
        {   // Want Ash to ride on charizard an flyyyyy!!
            // charizardASh.SetInteger("anim"
            // Transform tempTrans = ash.transform.parent;
            // ash.parent = charizardAsh.transform;
            // ash.transform.position = new Vector3(0,0,0);

        }
        // charizardASh.SetInteger("anim",0);
    }
}
