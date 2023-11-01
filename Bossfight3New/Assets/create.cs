using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    public Quaternion rotae = Quaternion.identity;
    public string key1;
    public GameObject itemPrefab1;
    public string key2;
    public GameObject itemPrefab2;
    public string key3;
    public GameObject itemPrefab3;
    int itemNum = 0;
    private GameObject pop;
    //public GameObject[,] littleboy = new GameObject[15, 11];

    // Start is called before the first frame update
    void Start()
    {
        pop = GameObject.Find("seller");
    }

    // Update is called once per frame
    void Update()
    {
        if (pop.GetComponent<sell>().money >= 25)
        {
            Debug.Log("RICH");
        }
        if (Input.GetKeyDown("r"))
        {
            rotae *= Quaternion.Euler(0, 0, 90);
            Debug.Log(rotae.eulerAngles);
        }       
        if (Input.GetKeyDown(key1))
        {
            WOW(itemPrefab1);

        }
        if (Input.GetKeyDown(key2))
        {
            WOW(itemPrefab2);
        }
        if (Input.GetKeyDown(key3))
        {
            WOW(itemPrefab3);
        }
        /*
        if (Input.GetKeyDown("m"))
        {
            Debug.Log("\n\n\nAAAAAAAAAAAA\n\n\n");
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (littleboy[i, j] != null)
                    {
                        Debug.Log("coordinates " + i + " " + j);
                        Debug.Log(littleboy[i, j].name);
                    }
                    
                }
            }
        }
        */

    }
    void WOW(GameObject waa)
    {
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPosition.z += 10;
        spawnPosition.x = Mathf.Round(spawnPosition.x);
        spawnPosition.y = Mathf.Round(spawnPosition.y);
        
        Vector3 rayDirection = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z) * Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(spawnPosition, rayDirection, 0.01f);
        if (hit.collider == null || hit.collider.CompareTag("item"))
        {
            if (pop.GetComponent<sell>().money >= 10)
            {
                pop.GetComponent<sell>().money -= 10;
                GameObject newItem = Instantiate(waa, spawnPosition, rotae);
                newItem.name = newItem.name + itemNum;
                itemNum++;
                Debug.Log(newItem.name + " made");
            }
             
            
        }
        
        
        
        /*
        int wa = (int)spawnPosition.x;
        Debug.Log(wa);
        int we = (int)spawnPosition.y * -1;
        Debug.Log(we);
        littleboy[wa,we] = newItem;
        Debug.Log("little boy");
        Debug.Log("x "+wa+" and y "+we);
        */
    }
    
}
