using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int money;
    public Text text;

    
    void Start()
    {


        money = 50;


    }

    // Update is called once per frame
    void Update()
    {


        text.text = "Money: " + money;

        if (Input.GetButtonDown("Fire1"))
            if (money - 10 < 0)
        {
            Debug.Log("you got no money bro");
        }

        else
        {
            money -= 10;
        }

        text.text = "MONEY : " + money;
        
    }

      
}


