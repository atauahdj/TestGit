using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Victorin : MonoBehaviour
{
    [SerializeField] private TMP_Text counter;
    [SerializeField] private TMP_InputField inputField;
    private int value = 0;

    private void Start()
    {
        value = UnityEngine.Random.Range(0, 101);
        counter.text = "Guess Number";
    }
    public void Restart()
    {
        value = UnityEngine.Random.Range(0, 101);
        counter.text = "Guess Number";
    }

    public void onCheckCLicker()
    {
        if (inputField.text.Equals(value.ToString()))
        {
            counter.text = "Your Guess!" + " Number = " + value;
        }

        else if (Convert.ToInt32(inputField.text) > value)
        {
            counter.text = "Number LESS " + inputField.text;
        }
        else if (Convert.ToInt32(inputField.text) < value)
        {
            counter.text = "Number MORE " + inputField.text;
        }


    }


    

}
