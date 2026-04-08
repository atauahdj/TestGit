using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Massive : MonoBehaviour
{

    private int value = 0;
    void Start()
    {
        value = UnityEngine.Random.Range(1,3);
        int[] first = {1,2,3,4};
        int[] second = {5,6,7,8};
        if(value == 1)
        {
            foreach (int a in first)
            {
                Debug.Log(a);
            }
            
        }
        else if(value == 2)
        {
            foreach(int b in second)
            {
                Debug.Log(b);
            }
        }
    }

}
