using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class _7to21 : MonoBehaviour
{
    [SerializeField] TMP_Text Result_Text;

    public void Score()
    {
        int min = 7;
        int max = 21;
        int want = 98;
        int got = Check(min, max);
        if (want == got)
        {
            Result_Text.text = $"Верно, сумма равна: {want}";
        }

        else if (want != got)
        {
            Result_Text.text = $"Неверно, сумма не равна: {want}";
        }
    }
    private int Check(int min, int max)
    {
        int total = 0;
        for (int current = min; current < max; current++)
        {
            if (current % 2 == 0)
            {
                total += current;
            }
        }
        return total;
    }
}