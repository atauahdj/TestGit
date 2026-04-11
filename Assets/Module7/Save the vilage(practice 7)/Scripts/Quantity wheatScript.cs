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
    public AudioSource GiveWheat;
    public TMP_Text Score_wheat;
    public float score2 = 0f;
    private float timer;
    public float interval;
    private bool unit;
    public TimerVillager timerVillager;
    void Start()
    {
        score2 = 2f;
        Score_wheat.text = $"Quantity wheat:{MathF.Round(score2)}";
    }
    void Update()
    {
        if (timerVillager.score > 0)
        {
            timer += Time.deltaTime;

            if (timer >= interval)
            {
                score2 += 1f;
                timer = 0f;
                GiveWheat.Play();
            }
            Score_wheat.text = $"Quantity wheat:{score2}";
        }
        if(interval <= 0.5f)
        {
            interval = 0.5f;
        }
    }
}
