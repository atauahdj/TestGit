using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class _NewBehaviourScript : MonoBehaviour
{
    public TMP_Text counter;
    public TMP_InputField inputField;
  
    public void readText()
    {
        if (inputField.text == "")
        {
            counter.text = "Enter text, please";
        }
        else
        {
            counter.text = inputField.text;
        }

        if (counter.text == "Meow")
        {
            counter.text = "Meow:)";
        }
        
    }
    


}
