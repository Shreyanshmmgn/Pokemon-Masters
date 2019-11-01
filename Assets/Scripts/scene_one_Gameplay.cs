using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_one_Gameplay : MonoBehaviour
{
    private Animator animator;
    private GameObject clone;
    public GameObject game_1;
    public Transform transform1;
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
    
}
