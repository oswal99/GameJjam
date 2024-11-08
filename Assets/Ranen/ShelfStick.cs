using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfStick : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Item")
        {
            collision.transform.SetParent(transform, false);
            collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;  
        }
    }
}
