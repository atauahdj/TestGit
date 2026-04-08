using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class memory_massive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = {1,2,3,4,5,6,7,8,9,10};
        foreach(int a in array)
        {
            if(a == 5)
            {
                break;
            }
            Debug.Log(a);
            
        }
      
    }

    // Update is called once per frame
    
}
