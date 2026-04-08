using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerVillager : MonoBehaviour
{
    public TMP_Text Score_villager_unit;
    public int score;
    public Image timer;
    private float currentTime = 1f;
    private bool timerRunning = false;
    public QuantitywheatScript scoreWheat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Timer()
    { 
        timerRunning = true;
    }
    void Update()
    {
        if(scoreWheat.score2 <= 0f)
        {
            scoreWheat.score2 = 0f;
        }
        if(scoreWheat.score2 >= 2f)
        {
            if (timerRunning)
            {
                currentTime -= Time.deltaTime;

                if (currentTime >= 0f)
                {
                    timer.fillAmount = currentTime;
                }

                if (currentTime <= 0f)
                {
                    currentTime = 1f;
                    timer.fillAmount = currentTime;
                    timerRunning = false;
                    ++score;
                    Score_villager_unit.text = $"Quantity : {score}";
                }
            }
        }
    }
}
