using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    public GameManager manager;
    public cameraMovement cameraMovement;
    private Animator animator;
    public bodyPart bodyPart;
    public int parts = 5;
    public Health health1;
    public Transform gameObject_with_intial_postion;
    // public Vector2 camPost, newPost;
    void Start()
    {
        animator = GetComponent<Animator>();
        // camPost = camera_1;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Deadly"))
        {
            health1.health = health1.health - 1;
            onExplode();

        }
        if (other.CompareTag("Bird"))
        {
            cameraMovement.animator.SetInteger("animState", 1);
            Invoke("offAnimation", 1);
            health1.health -= 1;
            Destroy(other.gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Charizard")
        {
            health1.health = health1.health - 2;
            onExplode();
        }
    }
    void offAnimation()
    {
        cameraMovement.animator.SetInteger("animState", 0);
    }
    void onExplode()
    {
        // Destroy(gameObject);
        gameObject.SetActive(false);
        var t = transform;
        for (int i = 0; i < parts; i++)
        {
            t.TransformPoint(0, -100, 0);
            bodyPart clone = Instantiate(bodyPart, t.position, Quaternion.identity) as bodyPart;
            clone.GetComponent<Rigidbody2D>().AddForce(Vector3.right * Random.Range(-50, 50));
            clone.GetComponent<Rigidbody2D>().AddForce(Vector3.up * Random.Range(100, 400));
        }
        gameObject.transform.position = gameObject_with_intial_postion.transform.position;
        gameObject.SetActive(true);
        // manager.restart_position_for_pikachu();
    }
}
