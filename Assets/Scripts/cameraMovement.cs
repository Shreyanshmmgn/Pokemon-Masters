using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    // public Camera camera_1;
    // private Transform camera_1;
    [SerializeField] Transform g1, g2;
    Vector3 cameraPos = Vector3.zero;
    public Animator animator;
    public GameObject Poke;
    private Vector3 offset = new Vector3(0, 0, -4);
    [SerializeField] GameObject Pokemon;
    [SerializeField] float X1, X2, Y1, Y2;
    // Transform camPosition;
    Vector3 camPosition;

    void Start()
    {
        // cameraPos = camera_1.position;
        // camera_1 = GetComponent<Camera>();
        // camera_1 = GetComponent<Transform>();
        // animator = GetComponent<Animator>();
        // intialPosition = camera_1.transform.position;    
        Poke = GameObject.FindGameObjectWithTag("Charizard");

    }
    public void newPosition()
    {
        gameObject.transform.position = g2.transform.position;
    }
    public void newPosition2()
    {
        gameObject.transform.position = g1.transform.position;
    }

    private void FixedUpdate()
    {
        if (Poke)
        {
            camPosition = Pokemon.transform.position;
            cameraPos.x = Mathf.Clamp(camPosition.x, X1, X2);
            cameraPos.y = Mathf.Clamp(camPosition.y, Y1, Y2);
            cameraPos = new Vector3(cameraPos.x, cameraPos.y, 0);
            transform.position = cameraPos + offset;
        }
    }
}
