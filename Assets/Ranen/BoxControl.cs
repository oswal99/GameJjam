using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    public string[] items;
    public GameObject[] shopItems;
    public GameObject spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButton(0))
        //{
           // WieghtedChoice();
        //}

    }


    public void WieghtedChoice()
    {   
        int randomNumber = Random.Range(0, shopItems.Length);
        Instantiate(shopItems[randomNumber], spawnPoint.transform.position, Quaternion.identity);

    }

    
}
