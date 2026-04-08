using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickerButton : MonoBehaviour
{
    public TMP_Text counter;
    int a = 0;

    public void throwoffClick()
    {
        a = 0;
        counter.text = "0";
        
    }

    public void onClick()
    {
        counter.text = (++a).ToString();
    }

    public void offClick()
    {
        counter.text = (--a).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
