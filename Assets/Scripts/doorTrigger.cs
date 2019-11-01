using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public Door door;
    public bool ignoreTrigger;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (ignoreTrigger) return;
        if (other.CompareTag("Player"))
        {
            door.open();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {   if (ignoreTrigger) return;
        if (other.CompareTag("Player"))
        {
            door.Close();
        }
    }
    public void Toggle(bool value)
    {
        if (value)
        {
            door.open();
        }
        else { door.Close(); }

    }
     void OnDrawGizmos() {
         Gizmos.color = ignoreTrigger ? Color.gray : Color.green;

         var bc2d = GetComponent<BoxCollider2D>();
         var bc2dPos = bc2d.transform.position;
         var newPos = new Vector2(bc2dPos.x ,bc2dPos.y +bc2d.offset.y);
         Gizmos.DrawWireCube (newPos,new Vector2(bc2d.size.x,bc2d.size.y));
    }
}
