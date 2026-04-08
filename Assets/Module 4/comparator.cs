using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class comparator : MonoBehaviour
{
    public TMP_InputField first_inputField;
    public TMP_InputField second_inputField;
    public TMP_Text result;
    public TMP_Text warning;
    void Start()
    {
        
    }

    
    public void Compare()
    {
        if ((second_inputField.text == "") || (first_inputField.text == ""))
        {
            warning.text = "You DONT enter number";
            result.text = "Result";
        }


        else if ((second_inputField.text == "") & (first_inputField.text == ""))
        {
            warning.text = "You DONT enter number";
            result.text = "Result";
        }

        else
        {
            warning.text = "";
            if (first_inputField.text.Equals(second_inputField.text))
            {
                result.text = "This numbers EQUAL";
            }
            else if (Convert.ToInt32(first_inputField.text) > Convert.ToInt32(second_inputField.text))
            {
                result.text = "First number MORE";
            }
            else if (Convert.ToInt32(first_inputField.text) < Convert.ToInt32(second_inputField.text))
            {
                result.text = "Second number MORE";
            }
        }
        

       
            
    }

}
