using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arifmetic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double a = 2;
        double b = 4;
        double z = a + b;
        double x = a - b;
        double c = a * b;
        double v = a / b;
        Debug.Log(z);
        Debug.Log(x);
        Debug.Log(c);
        Debug.Log(v);
    }

}
