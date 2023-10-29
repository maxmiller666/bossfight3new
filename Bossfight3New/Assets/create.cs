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
    public List<LinkedList<GameObject>> bigboy = new List<LinkedList<GameObject>>();
    int itemNum = 0;

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
        if (Input.GetKeyDown("u"))
        {
            int mooo = 0;
            Debug.Log("LINKED LIST SIZE : " + bigboy.Count);
            foreach (LinkedList<GameObject> u in bigboy)
            {
                Debug.Log("Linked List index : " + mooo + "\n");
                foreach (GameObject k in u)
                {
                    Debug.Log(k.name);
                }
                mooo++;
            }
        }
    }
    void WOW(GameObject waa)
    {
        bool hasfreinds = false;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); ;
        spawnPosition.z += 10;
        spawnPosition.x = Mathf.Round(spawnPosition.x);
        spawnPosition.y = Mathf.Round(spawnPosition.y);
        GameObject newItem = Instantiate(waa, spawnPosition, rotae);
        newItem.name = newItem.name + itemNum;
        itemNum++;
        if (input(newItem, Vector2.left))
        {
            hasfreinds = true;
            Debug.Log("INPUT");

        }
        else if (input(newItem, Vector2.down))
        {
            hasfreinds = true;
            Debug.Log("RIGHT");
        }
        else if (input(newItem, Vector2.up))
        {
            hasfreinds = true;
            Debug.Log("LEFT");
        }
        else if (output(newItem))
        {
            hasfreinds = true;
            Debug.Log("OUTPUTT");
        }
        if (hasfreinds == false)
        {
            
            nofreinds(newItem);
            
        }


        newItem.layer = 7;

    }
    void nofreinds(GameObject woop)
    {

        bigboy.Add(new LinkedList<GameObject>());
        int num = bigboy.Count - 1;
        bigboy[num].AddLast(woop);
    }

    bool output(GameObject obo)
    {
        Vector3 rayDirection = Quaternion.Euler(0, 0, obo.transform.rotation.eulerAngles.z) * Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(obo.transform.position, rayDirection, 1, LayerMask.GetMask("build"));



        if (hit.collider != null)
        {
            Debug.Log(hit.collider);
            Debug.Log(obo.transform.position);
            Debug.Log(BBindex(hit.collider));
            bigboy[BBindex(hit.collider)].AddFirst(obo);
            return true;
            
        }


        return false;
    }
    bool input(GameObject obo, Vector2 LR )
    {
        Vector3 rayDirection = Quaternion.Euler(0, 0, obo.transform.rotation.eulerAngles.z) * LR;
        RaycastHit2D hit = Physics2D.Raycast(obo.transform.position, rayDirection, 1, LayerMask.GetMask("build"));



        if (hit.collider != null)
        {
            Debug.Log(hit.collider);
            Debug.Log(obo.transform.position);
            Debug.Log(BBindex(hit.collider));
            bigboy[BBindex(hit.collider)].AddLast(obo);
            int old = BBindex(hit.collider);

            rayDirection = Quaternion.Euler(0, 0, obo.transform.rotation.eulerAngles.z) * Vector2.right;
            hit = Physics2D.Raycast(obo.transform.position, rayDirection, 1, LayerMask.GetMask("build"));
            if (hit.collider != null)
            {
                Debug.Log("merging");
                foreach (GameObject ap in bigboy[BBindex(hit.collider)])
                {
                    bigboy[old].AddLast(ap);
                }
                bigboy[BBindex(hit.collider)].Clear();
            }
            return true;

        }


        return false;
    }
    void merge()
    {

    }
    int BBindex(Collider2D collider)
    {
        foreach (LinkedList<GameObject> linkedList in bigboy)
        {
            foreach (GameObject go in linkedList)
            {
                if (go.GetComponent<Collider2D>() == collider)
                {
                    Debug.Log("Collider found in a LinkedList at index: " + bigboy.IndexOf(linkedList));
                    return (bigboy.IndexOf(linkedList));
                }
            }
        }

        // If the collider is not found in any LinkedList
        Debug.Log("Collider not found in any LinkedList.");
        return -1;
    }
}
/*
foreach (LinkedList<GameObject> lik in bigboy)
{

}
*/