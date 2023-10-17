using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnConveyer : MonoBehaviour
{
    // A flag to track whether the object is on a conveyor
    private int num;
    private bool turn = false;
    public ParticleSystem particleSystem;
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
            if (collision.transform.eulerAngles.z == 0)   {
                transform.Translate(Vector2.right * Time.deltaTime);
            }
            if (collision.transform.eulerAngles.z == 90)
            {
                transform.Translate(Vector2.up * Time.deltaTime);
            }
            if (collision.transform.eulerAngles.z == 180)
            {
                transform.Translate(Vector2.left * Time.deltaTime);
            }
            if (collision.transform.eulerAngles.z == 270)
            {
                transform.Translate(Vector2.down * Time.deltaTime);
            }

        }
        if (collision.gameObject.CompareTag("c1"))
        {
            if (num == 1)
            {
                if (collision.transform.eulerAngles.z == 0)
                {
                    transform.Translate(Vector2.up * Time.deltaTime);
                }
                if (collision.transform.eulerAngles.z == 90)
                {
                    transform.Translate(Vector2.left * Time.deltaTime);
                }
                if (collision.transform.eulerAngles.z == 180)
                {
                    transform.Translate(Vector2.down * Time.deltaTime);
                }
                if (collision.transform.eulerAngles.z == 270)
                {
                    transform.Translate(Vector2.left * Time.deltaTime);
                }
            }
        }



    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("conveyer"))
        {
            num += 1;
            Debug.Log(num + " Enter " + other);
        }
        if (other.gameObject.CompareTag("c1"))
        {
            turn = true;
            num += 1;
            Debug.Log(num + " Enter " + other);
        }
        if (other.gameObject.CompareTag("seller"))
        {
            
            Destroy(gameObject, 0.3f);
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("conveyer"))
        {

            num -= 1;
            Debug.Log(num+"Exit "+ collision);
        }
        if (collision.gameObject.CompareTag("c1"))
        {
            turn = false;
            num -= 1;
            Debug.Log(num + " Exit " + collision);
        }
        if (num == 0 && !turn)
        {
            Debug.Log("death");
            Destroy(gameObject, 0.3f);
        }
    }

    
}
