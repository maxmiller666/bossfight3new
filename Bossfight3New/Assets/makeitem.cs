using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeitem : MonoBehaviour
{
    public GameObject itemPrefab;
    public float spawnspeed = 2.0f;
    private float timepassed = 0;
    bool IHATENAMINGVARIABLRES;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        timepassed += Time.deltaTime;

        

        if (timepassed >= spawnspeed && IHATENAMINGVARIABLRES)
        {
            Spawn();
            timepassed = 0;
        }
    }
    void Spawn()
    {
        Vector3 spawnPosition = transform.position + Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z) * new Vector3(1, 0, 0);

        if (!ItemToTheRight())
        {
            GameObject newItem = Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
        }
    }
    bool ItemToTheRight()
    {
        Vector3 rayDirection = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z) * Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, rayDirection, 1, LayerMask.GetMask("ConveyerItem"));


        if (hit.collider != null)
        {
                return true;

        }


        return false;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("iron")) {
            IHATENAMINGVARIABLRES = true;
        }
    }
}

