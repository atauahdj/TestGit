using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class _Timer : MonoBehaviour
{
    #region Text's
    public TMP_Text TimerText;
    public TMP_Text QuantityText;
    public TMP_Text CurrentTimerLapsText;
    public TMP_Text PreviousTimerLapsText;
    #endregion
    #region float's
    private float currentLaps;
    public float counterTime;
    #endregion

    int laps = 0;
    
    private float previousLaps;

    void Start()
    {
        
    }

    private void Update()
    {
        //Timer
        counterTime = Mathf.Round(Time.time);
        TimerText.text = $"{Mathf.Round(counterTime)}";
    }

    public void TimeHandler()
    {
        LapsTime();
        QuantityLaps();
    }

    #region LapsTime
    private void LapsTime()
    {
        //LapsTime
        previousLaps = currentLaps;
        currentLaps = counterTime;
        CurrentTimerLapsText.text = $"Current time laps: {currentLaps}";
        PreviousTimerLapsText.text = $"Previous time laps: {previousLaps}";
    }
    #endregion
    #region Calculate
    private void QuantityLaps()
    {
        //QuantityLaps
        QuantityText.text = $"Quantity laps: {++laps}";
    }
    #endregion
}
