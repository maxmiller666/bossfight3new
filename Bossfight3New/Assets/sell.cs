using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sell : MonoBehaviour
{
    public int money = 100;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "MONEY : " + money;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            money += 1;
        }
        if (other.gameObject.CompareTag("aaa"))
        {
            money += 5;
        }
    }
}
