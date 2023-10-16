using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotate : MonoBehaviour
{
    public Text textR;
    private create weee;
    public GameObject Square;
    private string ss;
    // Start is called before the first frame update
    void Start()
    {
        weee = Square.GetComponent<create>();
    }

    // Update is called once per frame
    void Update()
    {
        if (weee.rotae.eulerAngles.z == 0){
            ss = "right";
        }
        if (weee.rotae.eulerAngles.z == 90)
        {
            ss = "up";
        }
        if (weee.rotae.eulerAngles.z == 180)
        {
            ss = "left";
        }
        if (weee.rotae.eulerAngles.z == 270)
        {
            ss = "down";
        }
        textR.text = "rotate " + ss;

    }
}
