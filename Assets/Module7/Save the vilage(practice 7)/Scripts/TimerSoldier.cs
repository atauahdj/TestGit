using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimerSoldier : MonoBehaviour
{
     public TMP_Text Score_soldier_unit;
    int score2;
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
        scoreWheat.score2 = scoreWheat.score2 - 3f;
    }
    void Update()
    {
        if(scoreWheat.score2 >= 3f)
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
                    ++score2;
                    Score_soldier_unit.text = $"Quantity : {score2}";
                }
            }
        }
    }
}
