using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Calc : MonoBehaviour
{

    [SerializeField] private TMP_InputField inputField_firstNumber;
    [SerializeField] private TMP_Text result;
    [SerializeField] private TMP_InputField inputField_secondNumber;
    public TMP_Text symbol;
    private double a = 0;
    private double b = 0;
   
    private void Start()
    {
        
    }
   

    public void ToFold()
    {
        a = Int64.Parse(inputField_firstNumber.text);
        b = Int64.Parse(inputField_secondNumber.text);
        
        double z = a + b;
        result.text = z.ToString();
        Debug.Log(z);
        symbol.text = "+";
        
        
    }
    public void ToDeducte()
    {
        a = Int64.Parse(inputField_firstNumber.text);
        b = Int64.Parse (inputField_secondNumber.text);

        double x = a - b;
        result.text = x.ToString();
        Debug.Log(x);
        symbol.text = "-";
    }
    public void ToMultiply()
    {
        a = Int64.Parse(inputField_firstNumber.text);
        b = Int64.Parse (inputField_secondNumber.text);

        double c = a * b;
        result.text = c.ToString();
        Debug.Log(c);
        symbol.text = "*";
    }
    public void ToDevide()
    {
        a = Int64.Parse(inputField_firstNumber.text);
        b = Int64.Parse (inputField_secondNumber.text);

        double v = a / b;
        result.text = v.ToString();
        Debug.Log(v);
        symbol.text = "/";
    }
    
    


        
    
   

   

}
