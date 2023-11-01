using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class murder : MonoBehaviour
{
    private GameObject pop;

    // Start is called before the first frame update
    void Start()
    {
        pop = GameObject.Find("seller");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
            pop.GetComponent<sell>().money += 10;
        }
    }
}
