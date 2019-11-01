using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    // public Camera camera_1;
    [SerializeField]
    public Transform g1,g2;
    [SerializeField]
    public Vector2 intialPosition;
    public Animator animator;
    void Start()
    {
        // camera_1 = GetComponent<Camera>();
        animator = GetComponent<Animator>();
        // intialPosition = camera_1.transform.position;     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void newPosition()
    {
        gameObject.transform.position = g2.transform.position;
    }
    public void newPosition2()
    {
        gameObject.transform.position = g1.transform.position;
    }
}
