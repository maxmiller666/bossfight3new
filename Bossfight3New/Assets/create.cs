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
    private int num;
    public List<LinkedList<GameObject>> bigboy = new List<LinkedList<GameObject>>();

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
        spawnPosition.x = Mathf.Round(spawnPosition.x);
        spawnPosition.y = Mathf.Round(spawnPosition.y);
        GameObject newItem = Instantiate(waa, spawnPosition, rotae);
        if (theright(newItem))
        {
            Debug.Log("OMG TO YOUR RIGHT");
        }
        newItem.layer = 7;

    }
    void nofreinds(GameObject woop)
    {

        bigboy[num] = new LinkedList<GameObject>();
        bigboy[num].AddLast(woop);

    }
    bool theright(GameObject obo)
    {

        Vector3 rayDirection = Quaternion.Euler(0, 0, obo.transform.rotation.eulerAngles.z) * Vector2.right;
        Debug.DrawRay(obo.transform.position, rayDirection, Color.green, 1);
        RaycastHit2D hit = Physics2D.Raycast(obo.transform.position, rayDirection, 2, LayerMask.GetMask("build"));



        if (hit.collider != null)
        {
            Debug.Log(hit.collider);
            Debug.Log(rayDirection);
            Debug.Log(obo.transform.position);
            
            Debug.DrawRay(obo.transform.position, rayDirection, Color.red, 1);
            return true;
            
        }


        return false;
    }
}
/*
foreach (LinkedList<GameObject> lik in bigboy)
{

}
*/