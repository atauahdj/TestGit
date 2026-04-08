using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class MassiveScore : MonoBehaviour
{
    [SerializeField] TMP_Text Result_Text;
    public void Score()
    {
        int[] arr = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = Check(arr);
        if (want == got)
        {
            Result_Text.text = $"Верно, сумма равна: {want}";
        }
        else if (want != got)
        {
            Result_Text.text = $"Неверно, сумма не равна: {want}";
        }
    }

    private int Check(int[] arr)
    {
        int total = 0;
        foreach(int i in arr)
        {
            if (i % 2 == 0)
            {
                total += i;
                
            }   
        }

        return total;
    }
   
}