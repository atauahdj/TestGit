using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerVillager : MonoBehaviour
{
    public Image timer;
    private float currentTime = 1f;
    private bool timerRunning = false;
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
            }
        }
    }
}
