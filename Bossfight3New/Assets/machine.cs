using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machine : MonoBehaviour
{
    public GameObject itemPrefabe;
    public float spawnspeedM = 2.0f;
    private float timepassed = 0;
    public string tag;
    public string tag2;
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

        if (!ItemToTheRight())
        {
            GameObject newItem = Instantiate(itemPrefabe, spawnPosition, Quaternion.identity);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(tag))
        {

        }
    }
    bool ItemToTheRight()
    {

        Vector3 rayDirection = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z) * Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, rayDirection, 2);



        if (hit.collider != null)
        {


            if (hit.collider.CompareTag(tag2))
            {
                return true;

            }
        }


        return false;
    }
}

