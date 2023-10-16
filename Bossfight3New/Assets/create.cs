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
    }
    void WOW(GameObject waa)
    {
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); ;
        spawnPosition.z += 10;
        GameObject newItem = Instantiate(waa, spawnPosition, rotae);
    }
}
