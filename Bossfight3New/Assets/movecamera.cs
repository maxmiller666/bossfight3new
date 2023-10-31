using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 5);
        }

        if (transform.position.x <= -5)
        {
            transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= 9)
        {
            transform.position = new Vector3(9, transform.position.y, transform.position.z);
        }

        if (transform.position.y >= 7.5f)
        {
            transform.position = new Vector3(transform.position.x, 7.5f, transform.position.z);
        }

        if (transform.position.y <= -6.5f)
        {
            transform.position = new Vector3(transform.position.x, -6.5f, transform.position.z);
        }
    }
}