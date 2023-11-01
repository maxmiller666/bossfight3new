using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machine : MonoBehaviour
{
    public GameObject itemPrefabe;
    public string tag;
    public int count;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        Vector3 spawnPosition = transform.position + Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z) * new Vector3(1, 0, 0);
        GameObject newItem = Instantiate(itemPrefabe, spawnPosition, Quaternion.identity);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(tag))
        {
            if (count > 2)
            {
                Spawn();
                count = 0;
            }
            count++;
        }
    }

}

