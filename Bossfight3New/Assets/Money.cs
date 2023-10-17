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
<<<<<<< Updated upstream


        money = 50;


=======
        money = 50;
        
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            if (money - 10 > 0)
            {
               money -= 10;
            }

        else
            {
                Debug.Log("your broke");
            }


        text.text = "Money: " + money;

<<<<<<< Updated upstream
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
=======
>>>>>>> Stashed changes
        
    }

      
}


