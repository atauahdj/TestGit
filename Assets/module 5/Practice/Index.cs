
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Index : MonoBehaviour
{
    [SerializeField] TMP_Text Result_Text;
    public void index()
    {
        
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = 3;
        int got = FirstOccurrence(array, value);
        Debug.Log($"Index::index(); --{got}");
        if (got == want)
        {
            Result_Text.text = $"Индекс первого вхождения числа {value} равен {got}";
        }

        /*array = new int[] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        want = -1;
        value = 55;
        if (got != want)
        {
            Result_Text.text = $"Индекса первого вхождения y числа {value} нету({want})";
        }*/
    }

    private int FirstOccurrence(int[] array, int value)
    {
        for (int curr = 0; curr < array.Length; curr++)
        {
            if (array[curr] == value)
            {
                return curr;
            }
        }
        return -1;
    }
}
