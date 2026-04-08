using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Numbereasy : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void Start()
    {
        int n = 13;
        if (n > 0)
        {
            for (int i = 2; i < n; ++i)
            {
                if(i % n == 0)
                {
                    Debug.Log($"The number {n} easy");
                }
            }
        }
    }
}
