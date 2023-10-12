using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnConveyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("collide");
        if (collision.gameObject.CompareTag("conveyer"))
        {
            Debug.Log("hit");
            transform.Translate(Vector2.right * Time.deltaTime);
        }
    }
}
