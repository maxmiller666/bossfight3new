using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeitem : MonoBehaviour
{
    public GameObject itemPrefab;
    public float spawnspeed = 2.0f;
    private float timepassed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        timepassed += Time.deltaTime;

        
        if (ItemToTheRight())
        {
            timepassed = -5;
        }
        if (timepassed >= spawnspeed)
        {
            Spawn();
            timepassed = 0;
        }
    }
    void Spawn()
    {
        Vector3 spawnPosition = transform.position + new Vector3(1, 0, 0);
        GameObject newItem = Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
    }
    bool ItemToTheRight()
    {
        // Cast a ray to the right
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 2);

        // Check if the ray hits something
        if (hit.collider != null)
        {
            
            // If it hits an item, return true (there is an item to the right)
            if (hit.collider.CompareTag("item"))
            {
                return true;
                
            }
        }

        // No item to the right
        return false;
    }
}

