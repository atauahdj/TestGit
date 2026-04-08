using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class Sort : MonoBehaviour
{

    private void Start()
    {
        int [] array = _Sort(10);
        //WrittenSort(array); 
        BubbleSort(array);
        Debug.Log("array: " + string.Join(", ", array));
        Debug.Log("array: " + string.Join(", ", array));
        //WrittenSort(array);
    }


    private int[] _Sort(int length)
    {
        int[] arr = new int[length];
        Random rnd = new Random();

        for (int i = 0; i < length; ++i)
        {
            arr[i] = rnd.Next(0,11);
        }
        


        return arr;


    }

    private void WrittenSort(int[] arr)
    {
        foreach (int a in arr)
        {
            Debug.Log(a);
        }
    }
    private void BubbleSort(int[] arr)
    {
        int temp = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr.Length - i - 1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
