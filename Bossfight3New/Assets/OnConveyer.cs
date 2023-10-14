using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnConveyer : MonoBehaviour
{
    // A flag to track whether the object is on a conveyor
    private int num;

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
        if (collision.gameObject.CompareTag("conveyer"))
        {
            transform.Translate(Vector2.right * Time.deltaTime);
        }
        

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("conveyer"))
        {
            num += 1;
            Debug.Log(num + "Enter" + other);
        }
        
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("conveyer"))
        {

            num -= 1;
            Debug.Log(num+"Exit "+ collision);
        }
        if (num == 0)
        {
            Debug.Log("death");
            Destroy(gameObject, 2);
        }
    }
}