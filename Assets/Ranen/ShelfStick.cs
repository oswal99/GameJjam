using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfStick : MonoBehaviour
{
    private int count;

    public void Start()
    {
        count = 0;
       
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Item")
        {
            collision.transform.SetParent(transform, false);
            collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
           count =  count + 1;
            CountList();
        }
    }

    private void CountList()
    {
        if(count >= 12)
        {
            Application.LoadLevel("Win");
        }
    }
    
}
