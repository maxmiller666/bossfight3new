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
    int itemNum = 0;
    public GameObject[,] littleboy = new GameObject[15, 11];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
        if (Input.GetKeyDown("m"))
        {
            Debug.Log("\n\n\nAAAAAAAAAAAA\n\n\n");
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Debug.Log("coordinates " + i + " " + j);
                    Debug.Log(littleboy[i, j].name);
                }
            }
        }

    }
    void WOW(GameObject waa)
    {

        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); ;
        spawnPosition.z += 10;
        spawnPosition.x = Mathf.Round(spawnPosition.x);
        spawnPosition.y = Mathf.Round(spawnPosition.y);
        GameObject newItem = Instantiate(waa, spawnPosition, rotae);
        newItem.name = newItem.name + itemNum;
        itemNum++;
        Debug.Log(newItem.name + " made");
        littleboy[(int)spawnPosition.x, (int)spawnPosition.y * -1] = newItem;
        Debug.Log("little boy");
        Debug.Log("x "+(int)spawnPosition.x+" and y "+(int)spawnPosition.y * -1);




    }
    
}
