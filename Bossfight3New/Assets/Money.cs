using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int money;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("amount");
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
        {
            money += 1;
            PlayerPrefs.SetInt("amount", money);
        }

        text.text = "" + money;
    }
}
