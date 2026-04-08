using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerVillager : MonoBehaviour
{
    public Image timer;
    private float currentTime = 1f;
    private bool runTimer;
    
    void Start()
    {
        timer = GetComponent<Image>();
    }

    // Update is called once per frame
    public void _TimerVillagerPause()
    {
        if (runTimer)
        {
            currentTime -= Time.deltaTime;
        }

        if (!runTimer)
        {
            currentTime = currentTime;
        }
        runTimer = !runTimer;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        Debug.Log(currentTime);
        timer.fillAmount = currentTime;
    }
}
