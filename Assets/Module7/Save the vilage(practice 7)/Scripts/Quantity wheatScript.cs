using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class QuantitywheatScript : MonoBehaviour
{
    public TMP_Text Score_wheat;
    public float score2 = 0f;
    private bool unit;
    public TimerVillager timerVillager;
    void Start()
    {
        score2 = 2f;
        Score_wheat.text = $"Quantity wheat:{MathF.Round(score2)}";
    }
    void Update()
    {
        if(timerVillager.score > 0)
        {
            score2 += Time.deltaTime;
            Score_wheat.text = $"Quantity wheat:{MathF.Round(score2)}";
        }
    }
}
