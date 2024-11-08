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
        //WieghtedChoice();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //CallThis();
            WieghtedChoice();
            //print(allItems.itemList[0].items.Count);
        }


    }
    void CallThis()
    {
        for (int i = 0; i < 100; i++)
        {
            WieghtedChoice();
        }
    }

    void RandomChoice()
    {
        float randFloat = Random.Range(1, 100);
        //randFloat *= 100;
        //print(randFloat);

        if (randFloat >= 0 && randFloat <= 50)
        {
            print(items[0]);
        }
        else if (randFloat >= 50 && randFloat <= 60)
        {
            float randomNum = Random.Range(1f, 3f);
            if(randomNum >= 1f && randomNum <= 2f)
            {
                print(items[1]);
            }
            else if (randomNum >= 2f && randomNum <= 2.5f)
            {
                print(items[2]);
            }
            else if (randomNum >= 2.5f && randomNum <= 3f)
            {
                print(items[3]);
            }
            //print(items[randomNum]);
        }
        else if (randFloat >= 60 && randFloat <= 65 )
        {
            print(items[4]);
        }
        else if (randFloat >= 65 && randFloat <= 71)
        {
            print(items[5]);
        }
        else if (randFloat >= 71 && randFloat <= 77)
        {
            print(items[6]);
        }
        else if (randFloat >= 77 && randFloat <= 83)
        {
            print(items[7]);
        }
        else if (randFloat >= 83 && randFloat <= 89)
        {
            print(items[8]);
        }
        else if (randFloat >= 89 && randFloat <= 95)
        {
            print(items[9]);
        }
        else if (randFloat >= 95 && randFloat <= 98)
        {
            print(items[10]);
        }
        else if (randFloat >= 98 && randFloat <= 100)
        {
            print(items[11]);
        }
    }

    void WieghtedChoice()
    {
        //int randomNumber = Random.Range(1, 100);
        
        int randomNumber = Random.Range(0, items.Length);
        //print(items[randomNumber]);
        Instantiate(shopItems[randomNumber], spawnPoint.transform.position, Quaternion.identity);


    }

    
}
