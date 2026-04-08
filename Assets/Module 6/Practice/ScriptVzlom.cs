using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class ScriptVzlom : MonoBehaviour
{
    #region PinText
    public TMP_Text pinText1;
    public TMP_Text pinText2;
    public TMP_Text pinText3;
    #endregion
    public GameObject LoseCanvas;
    public GameObject WinCanvas;
    public TMP_Text timerText;
    private float currentTime;
    #region int
    int pin1 = 7;
    int pin2 = 3;
    int pin3 = 5;
    #endregion
    #region Timer
    void Start()
    {
        currentTime = 60f;
    }
    void Update()
    {
        if(currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
        }
        timerText.text = $"{Math.Round(currentTime, 2)}";
        //Retry
        if (currentTime <= 0f)
        {
            LoseCanvas.SetActive(true);
        }
        if (pin1 == pin2 && pin2 == pin3)
        {
            WinCanvas.SetActive(true);
        }
        Pin(pin1);
        Pin(pin2);
        Pin(pin3);
    }
    #endregion
    public void Restart()
    {
        Debug.Log("ScriptVzlom::Restart(); -- currentTime:" + currentTime);
        LoseCanvas.SetActive(false);
        WinCanvas.SetActive(false);
        pin1 = 7;
        pin2 = 3;
        pin3 = 5;
        pinText1.text = $"{pin1}";
        pinText2.text = $"{pin2}";
        pinText3.text = $"{pin3}";
        currentTime = 60f;
    }
    #region InstrumentalFuntcion
    public void DrillFunction()
    {
        pin1 = pin1 + 1;
        pin2 = pin2 - 1;
        pinText1.text = $"{pin1}";
        pinText2.text = $"{pin2}";
        Debug.Log($"{pin1}, {pin2}, {pin3}");
    }
    public void HummerFunction()
    {
        pin1 = pin1 - 1;
        pin2 = pin2 + 2;
        pin3 = pin3 - 1;
        pinText1.text = $"{pin1}";
        pinText2.text = $"{pin2}";
        pinText3.text = $"{pin3}";
        Debug.Log($"{pin1}, {pin2}, {pin3}");
    }
    public void LockpickFunction()
    {
        pin1 = pin1 - 1;
        pin2 = pin2 + 1;
        pin3 = pin3 + 1;
        pinText1.text = $"{pin1}";
        pinText2.text = $"{pin2}";
        pinText3.text = $"{pin3}";
        Debug.Log($"{pin1}, {pin2}, {pin3}");
    }
    #endregion

    private void Pin(float A)
    {
        if((A > 10) | (A < 0))
        {
            LoseCanvas.SetActive(true);
        }
    }
}

