using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyPart : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    private Renderer rendere;
    private Color start, end;
    private float t = 0.0f;

    void Start()
    {   rendere = GetComponent<Renderer>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        start = spriteRenderer.color;
        end = new Color (start.r, start.g, start.b, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        rendere.material.color = Color.Lerp(start, end, t /2);

        if(rendere.material.color.a <= 0.0)Destroy(gameObject);
        
    }
}
