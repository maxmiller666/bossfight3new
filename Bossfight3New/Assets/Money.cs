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
        money = 50;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + money;
        
    }
}
