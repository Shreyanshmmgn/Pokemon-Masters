using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    // [SerializeField] Transform initialPosition;
    // Start is called before the first frame update    
    void Start()
    {
        // DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Awake()
    {
        // gameObject.transform.position = initialPosition.position;
    }
}
